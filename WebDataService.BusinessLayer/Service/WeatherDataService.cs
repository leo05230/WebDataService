using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebDataService.Domain.ApiModel;
using WebDataService.Domain.Entities;
using WebDataService.Domain.Enums;
using WebDataService.Domain.Interfaces;
using WebDataService.Domain.Interfaces.API;
using WebDataService.Domain.Interfaces.Common;
using WebDataService.Domain.Interfaces.DataSet;
using WebDataService.Domain.Interfaces.Service;

namespace WebDataService.BusinessLayer.Service
{
	public class WeatherDataService : IWeatherDataService
	{
		private readonly IDTF _IDTF;
		private readonly IResult _IResult;
		private readonly ICodeAreaRepository _ICodeAreaRepository;
		private readonly ICodeLocationRepository _ICodeLocationRepository;
		private readonly IWeatherMainRepository _IWeatherMainRepository;
		private readonly IApiManagers _IApiManagers;
		private readonly IConfiguration _Configuration;

		public WeatherDataService
		(
			IDTF IDTF,
			IResult IResult,
			ICodeAreaRepository ICodeAreaRepository,
			ICodeLocationRepository ICodeLocationRepository,
			IWeatherMainRepository IWeatherMainRepository,
			IApiManagers IApiManagers,
			IConfiguration Configuration
		)
		{
			this._IDTF = IDTF;
			this._IResult = IResult;
			this._ICodeAreaRepository = ICodeAreaRepository;
			this._ICodeLocationRepository = ICodeLocationRepository;
			this._IWeatherMainRepository = IWeatherMainRepository;
			this._IApiManagers = IApiManagers;
			this._Configuration = Configuration;
		}
		public Task<IResult> Save(string strLocationID)
		{
			DateTime dtTime = DateTime.Now;
			return SaveData(strLocationID, dtTime);
		}

		public Task<IResult> Save(string strLocationID, DateTime dtTime)
		{
			return SaveData(strLocationID, dtTime);
		}

		private async Task<IResult> SaveData(string strLocationID, DateTime dtTime)
		{

			this._IResult.Success = false;
			var CheckData = await this._IWeatherMainRepository.GetQuery(dtTime, strLocationID);			

			if (CheckData == null)
			{
				string strUrl = this._Configuration.GetSection("WeatherAPI").Value;
				var csCodeArea = this._ICodeAreaRepository.GetAll();
				var csCodeLocation = this._ICodeLocationRepository.GetAll();
				string strHiours = DateTime.Now.Hour >= 12 ? "12" : "06";
				var Result = await this._IApiManagers.Get<Weather>(string.Format(strUrl, strLocationID, dtTime.ToString("yyyy-MM-dd"), strHiours));
				if (Result != null)
				{
					WeatherMain csWeatherMain = new WeatherMain();
					csWeatherMain.ApiId = strLocationID;
					var Locations = Result.records.locations;

					#region 資料整理
					foreach (var item in Locations)
					{
						#region 未建立CODELocation表資料
						if (!(await csCodeLocation).Any(x => x.Id == item.dataid))
						{
							CodeLocation CodeLocation = new CodeLocation()
							{
								Id = item.dataid,
								Name = item.locationsName
							};
							var LocationResult = await this._ICodeLocationRepository.Create(CodeLocation);
							if (!LocationResult.Success)
							{
								this._IResult.Success = false;
								this._IResult.Message = LocationResult.Message + LocationResult.Exception.Message + LocationResult.Exception.StackTrace;
								break;
							}
						}
						#endregion

						foreach (var Location in item.location)
						{
							#region 未建立CODEArea表資料
							if (!(await csCodeArea).Any(x => x.Id == Location.geocode))
							{
								CodeArea CodeArea = new CodeArea()
								{
									Id = Location.geocode,
									CodeLocation = item.dataid,
									Name = Location.locationName
								};
								var AreaResult = await this._ICodeAreaRepository.Create(CodeArea);
								if (!AreaResult.Success)
								{
									this._IResult.Success = false;
									this._IResult.Message = AreaResult.Message + AreaResult.Exception.Message + AreaResult.Exception.StackTrace;
									break;
								}
							}
							#endregion

							csWeatherMain.LocationId = item.dataid;
							csWeatherMain.Date = dtTime;
							csWeatherMain.Ctime = DateTime.Now;
							WeatherDetail csWeatherDetail = new WeatherDetail();
							foreach (var Weather in Location.weatherElement)
							{
								csWeatherDetail.AreaId = Location.geocode;
								var ElementName = (WEATHER)Enum.Parse(typeof(WEATHER), Weather.elementName, true);
								var ValueModel = Weather.time.FirstOrDefault();

								#region 天氣各節點資料
								switch (ElementName)
								{
									case WEATHER.PoP12h:
										csWeatherDetail.StartTime = "0600";
										csWeatherDetail.EndTime = "1200";
										if (ValueModel != null)
										{
											DateTime dtStartTime = Convert.ToDateTime(ValueModel.startTime);											
											csWeatherDetail.RainRatio = Convert.ToDecimal(ValueModel.elementValue.FirstOrDefault().value);
										}
										else
										{
											csWeatherDetail.RainRatio = 0;
										}
										break;
									case WEATHER.Wx:
										if (ValueModel != null)
										{
											csWeatherDetail.States = ValueModel.elementValue.FirstOrDefault().value;
										}
										else
										{
											csWeatherDetail.States = "N/A";
										}
										break;
									case WEATHER.AT:
										if (ValueModel != null)
										{
											csWeatherDetail.BodyTemperature = Convert.ToDecimal(ValueModel.elementValue.FirstOrDefault().value);
										}
										else
										{
											csWeatherDetail.BodyTemperature = 0;
										}
										break;
									case WEATHER.T:
										if (ValueModel != null)
										{
											csWeatherDetail.Temperature = Convert.ToDecimal(ValueModel.elementValue.FirstOrDefault().value);
										}
										else
										{
											csWeatherDetail.Temperature = 0;
										}
										break;
									case WEATHER.RH:
										if (ValueModel != null)
										{
											csWeatherDetail.Humidity = Convert.ToDecimal(ValueModel.elementValue.FirstOrDefault().value);
										}
										else
										{
											csWeatherDetail.Humidity = 0;
										}
										break;
									case WEATHER.CI:
										if (ValueModel != null)
										{
											csWeatherDetail.ComfortIndex = Convert.ToDecimal(ValueModel.elementValue[0].value);
											csWeatherDetail.Comfort = ValueModel.elementValue[1].value;
										}
										else
										{
											csWeatherDetail.ComfortIndex = 0;
											csWeatherDetail.Comfort = "N/A";
										}
										break;
									case WEATHER.WeatherDescription:
										if (ValueModel != null)
										{
											csWeatherDetail.Detail = ValueModel.elementValue.FirstOrDefault().value;
										}
										else
										{
											csWeatherDetail.Detail = "N/A";
										}
										break;
									case WEATHER.WS:
										if (ValueModel != null)
										{
											csWeatherDetail.WindSpeed = Convert.ToDecimal(ValueModel.elementValue.FirstOrDefault().value);
										}
										else
										{
											csWeatherDetail.WindSpeed = 0;
										}
										break;
									case WEATHER.WD:
										if (ValueModel != null)
										{
											csWeatherDetail.WindDirection = ValueModel.elementValue.FirstOrDefault().value;
										}
										else
										{
											csWeatherDetail.WindDirection = "N/A";
										}
										break;
									case WEATHER.Td:
										if (ValueModel != null)
										{
											csWeatherDetail.DewPoint = Convert.ToDecimal(ValueModel.elementValue.FirstOrDefault().value);
										}
										else
										{
											csWeatherDetail.DewPoint = 0;
										}
										break;
								}
								#endregion
							}
							csWeatherMain.WeatherDetails.Add(csWeatherDetail);
						}
					}
					#endregion

					var DBResult = await this._IWeatherMainRepository.Create(csWeatherMain);
					this._IResult.Success = DBResult.Success;
					this._IResult.Exception = DBResult.Exception;
					this._IResult.Message = DBResult.Message;
				}

			}
			else
			{
				this._IResult.Success = false;
				this._IResult.Message = "已有該天資料";
			}
			return this._IResult;
		}
	}
}
