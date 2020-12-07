using System;
using System.Collections.Generic;
using System.Text;
using WebDataService.Domain.Interfaces;

namespace WebDataService.BusinessLayer
{
	public class Result : IResult
	{
		public Guid ID
		{
			get;
			private set;
		}

		public bool Success
		{
			get;
			set;
		}

		public string Message
		{
			get;
			set;
		}

		public Exception Exception
		{
			get;
			set;
		}

		public List<IResult> InnerResults
		{
			get;
		}

		public Result()
			: this(false)
		{
		}

		public Result(bool success)
		{
			ID = Guid.NewGuid();
			Success = success;
			InnerResults = new List<IResult>();
		}

	}
}
