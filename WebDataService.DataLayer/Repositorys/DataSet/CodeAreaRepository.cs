using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDataService.DataLayer.UnitOfWork;
using WebDataService.Domain.Entities;
using WebDataService.Domain.Interfaces;
using WebDataService.Domain.Interfaces.ConnectionStringProvider;
using WebDataService.Domain.Interfaces.DataSet;

namespace WebDataService.DataLayer.Repositorys.DataSet
{
	public class CodeAreaRepository : ICodeAreaRepository
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IRepository<CodeArea> _repository;
		private readonly IConnectionStringProvider _connectionstringprovider;
		private readonly IResult _result;
		public CodeAreaRepository
		(
			IUnitOfWork unitofwork, 
			IRepository<CodeArea> repository,
			IConnectionStringProvider connectionStringProvider,
			IResult IResult
		)
		{
			this._unitOfWork = unitofwork;
			this._repository = repository;
			this._connectionstringprovider = connectionStringProvider;
			this._result = IResult;
		}

		public Task<IResult> Create(CodeArea Model)
		{
			this._result.Success = false;
			try
			{
				this._result.Message = "正在執行 insert CodeArea ";
				this._repository.Create(Model);
				this._unitOfWork.SaveChange();
				this._result.Success = true;
			}
			catch (Exception e)
			{
				this._result.Exception = e;
			}
			return Task.FromResult(this._result);
		}

		public Task<IQueryable<CodeArea>> GetAll()
		{
			return Task.FromResult(this._repository.GetAll());
		}
	}
}
