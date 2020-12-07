using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WebDataService.Domain.Entities;
using WebDataService.Domain.Interfaces;
using WebDataService.Domain.Interfaces.Common;
using WebDataService.Domain.Interfaces.DataSet;
using WebDataService.Domain.Interfaces.Service;

namespace WebDataService.BusinessLayer.Service
{
	public class MetroService : IMetroService
	{
		private readonly IDTF _IDTF;
		private readonly IResult _IResult;
		private readonly IMetroFlowNumberRepository _IMetroFlowNumberRepository;
		private readonly IConfiguration _Configuration;

		public MetroService
		(
			IDTF IDTF,
			IResult IResult,
			IMetroFlowNumberRepository IMetroFlowNumberRepository,
			IConfiguration Configuration
		)
		{
			this._IDTF = IDTF;
			this._IResult = IResult;
			this._IMetroFlowNumberRepository = IMetroFlowNumberRepository;
			this._Configuration = Configuration;
		}

		public Task<IResult> Save(DateTime dtTime)
		{
			this._IResult.Success = false;
			var CheckModel = this._IMetroFlowNumberRepository.GetQuery(dtTime).Result;
			if (CheckModel == null)
			{
				#region 抓資料
				WebClient wc = new WebClient();
				DateTime dtEndTime = dtTime.AddMonths(1);
				var dict = new Dictionary<string, byte[]>();
				string strUrl = this._Configuration.GetSection("MetroUrl").Value;
				documentcontent csXmlDocument = new documentcontent();
				//https://web.metro.taipei/RidershipPerStation/202010_cht.ods
				var stream = wc.DownloadData(string.Format(strUrl, dtTime.ToString("yyyyMM")));
				wc.Dispose();
				#endregion

				if (stream.Length > 0)
				{
					try
					{
						#region 讀資料(ODS >> XML)
						using (var msZip = new MemoryStream(stream))
						{
							using (var archive = new ZipArchive(msZip, ZipArchiveMode.Read))
							{
								var Data = archive.Entries.FirstOrDefault(x => x.FullName == "content.xml");
								if (Data != null && Data.Length > 0)
								{
									using (var entryStream = Data.Open())
									{
										XmlSerializer serializer = new XmlSerializer(typeof(documentcontent));
										csXmlDocument = (documentcontent)serializer.Deserialize(entryStream);
									}
								}
							}

						}
						#endregion

						List<MetroFlowNumber> csMetroFlowNumberColl = new List<MetroFlowNumber>(); 
						List<string> csStation = new List<string>(); // 各車站名稱
						table csOutNumber = new table(); // 出站資料
						table csInNumber = new table(); // 進站資料
						int i = 0;

						#region 抓車站名稱
						if (csXmlDocument != null && csXmlDocument.body.spreadsheet.table.Count() > 0)
						{
							csOutNumber = csXmlDocument.body.spreadsheet.table[0];
							csInNumber = csXmlDocument.body.spreadsheet.table[1];
							var Station = csOutNumber.tablerow[0].tablecell.Select(x => x.p);
							foreach (var item in Station)
							{
								if (i > 0)
								{
									if (item != null && item[0].Text != null && item[0].Text.Length > 0)
									{
										csStation.Add(item[0].Text[0]);
									}
								}
								i++;
							}
						}
						#endregion

						#region 整理資料
						int n = 1; 
						while (dtTime < dtEndTime)
						{
							i = 1;

							foreach (var item in csStation)
							{
								MetroFlowNumber csMetroFlowNumber = new MetroFlowNumber();
								csMetroFlowNumber.RecordDate = dtTime;
								csMetroFlowNumber.Station = item;
								string strOut = csOutNumber.tablerow[n].tablecell[i].p[0].Text[0].Replace(",", "");
								string strIn = csInNumber.tablerow[n].tablecell[i].p[0].Text[0].Replace(",", "");
								Int32.TryParse(strOut, out int nOut);
								Int32.TryParse(strIn, out int nInt);
								csMetroFlowNumber.Outbound = nOut;
								csMetroFlowNumber.Inbound = nInt;
								csMetroFlowNumberColl.Add(csMetroFlowNumber);
								i++;
							}
							n++;
							dtTime = dtTime.AddDays(1);
						}
						#endregion

						if (csMetroFlowNumberColl.Count > 0)
						{
							var DBResult = this._IMetroFlowNumberRepository.Create(csMetroFlowNumberColl).Result;
							this._IResult.Success = DBResult.Success;
							this._IResult.Exception = DBResult.Exception;
							this._IResult.Message = DBResult.Message;
						}
					}
					catch (Exception e)
					{
						this._IResult.Exception = e;
						this._IResult.Message = "Error!";
					}
				}
				else
				{
					this._IResult.Success = false;
					this._IResult.Message = "查無該月份資料來源。";
				}
			}
			else
			{
				this._IResult.Success = false;
				this._IResult.Message = "已有該月份資料。";
			}
			return Task.FromResult(this._IResult);
		}
	}
}
