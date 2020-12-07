using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebDataService.DataLayer.UnitOfWork;
using WebDataService.Domain.Entities;
using WebDataService.Domain.Interfaces;
using WebDataService.Domain.Interfaces.ConnectionStringProvider;
using WebDataService.Domain.Interfaces.DataSet;

namespace WebDataService.DataLayer.Repositorys.DataSet
{
	public class WeatherMainRepository : IWeatherMainRepository
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IRepository<WeatherMain> _repository;
		private readonly IConnectionStringProvider _connectionstringprovider;
		private readonly IResult _result;
		public WeatherMainRepository(IUnitOfWork unitofwork, IRepository<WeatherMain> repository, IConnectionStringProvider connectionStringProvider, IResult IResult)
		{
			this._unitOfWork = unitofwork;
			this._repository = repository;
			this._connectionstringprovider = connectionStringProvider;
			this._result = IResult;
		}

		public Task<IResult> Create(WeatherMain Model)
		{
			this._result.Success = false;
			try
			{
				this._result.Message = "正在執行 insert WeatherMain ";
				this._repository.Create(Model);
				this._unitOfWork.SaveChange();
				this._result.Success = true;
				this._result.Message = "insert WeatherMain OK!";
			}
			catch (Exception e)
			{
				this._result.Exception = e;
			}
			return Task.FromResult(this._result);
		}

		public Task<IQueryable<WeatherMain>> GetAll()
		{			
			return Task.FromResult(this._repository.GetAll());
		}

		public Task<WeatherMain> GetQuery(DateTime dtTime, string strApiId)
		{
			return Task.FromResult(this._repository.Get(x => x.Date == dtTime && x.ApiId == strApiId));
		}
	}
}
