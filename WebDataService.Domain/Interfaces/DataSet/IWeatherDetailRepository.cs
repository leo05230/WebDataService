using System;
using System.Linq;
using System.Threading.Tasks;
using WebDataService.Domain.Entities;

namespace WebDataService.Domain.Interfaces.DataSet
{
	public interface IWeatherDetailRepository
	{
		Task<IQueryable<WeatherDetail>> GetAll();
		Task<WeatherDetail> GetQuery(int nMainNo);
		Task<IResult> Create(WeatherDetail Model);
	}
}
