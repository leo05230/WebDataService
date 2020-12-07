using System.Linq;
using System.Threading.Tasks;
using WebDataService.Domain.Entities;

namespace WebDataService.Domain.Interfaces.DataSet
{
	public interface ICodeLocationRepository
	{
		Task<IQueryable<CodeLocation>> GetAll();
		Task<IResult> Create(CodeLocation Model);
	}
}
