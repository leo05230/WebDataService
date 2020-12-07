using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebDataService.Domain.Interfaces.Service
{
	public interface IMetroService
	{
		public Task<IResult> Save(DateTime dtTime);
		
	}
}
