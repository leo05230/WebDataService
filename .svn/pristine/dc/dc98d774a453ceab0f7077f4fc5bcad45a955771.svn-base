using System;
using System.Linq;
using System.Threading.Tasks;
using WebDataService.Domain.Entities;

namespace WebDataService.Domain.Interfaces.DataSet
{
	public interface IWeatherMainRepository
	{
		Task<IQueryable<WeatherMain>> GetAll();
		Task<WeatherMain> GetQuery(DateTime dtTime, string strLocationId);
		Task<IResult> Create(WeatherMain Model);
	}
}
