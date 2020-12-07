using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebDataService.Domain.Interfaces.Service
{
	public interface IWeatherDataService
	{
		public Task<IResult> Save(string strLocationID);
		public Task<IResult> Save(string strLocationID, DateTime dtTime);
		
	}
}
