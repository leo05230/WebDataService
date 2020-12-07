using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDataService.Domain.Entities;

namespace WebDataService.Domain.Interfaces.DataSet
{
	public interface IMetroFlowNumberRepository
	{
		Task<IQueryable<MetroFlowNumber>> GetAll();
		Task<MetroFlowNumber> GetQuery(DateTime dtTime);
		Task<IResult> Create(MetroFlowNumber Model);
		Task<IResult> Create(List<MetroFlowNumber> Model);
	}
}
