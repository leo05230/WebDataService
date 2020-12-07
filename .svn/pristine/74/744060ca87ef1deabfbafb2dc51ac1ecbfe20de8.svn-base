using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Threading.Tasks;

namespace WebDataService.Domain.Interfaces.API
{
	public interface IApiManagers
	{
		Task<T> Get<T>(string strUrl);
		Task<T> Post<T>(string strUrl, NameValueCollection csQueryParameter);
	}
}
