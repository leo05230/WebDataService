using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using WebDataService.Domain.Interfaces.Common;

namespace WebDataService.Shared.Common
{
	public class DTF : IDTF
	{
		
		public string GetResult<T1, T2>(Dictionary<T1, T2> dicSource, T1 Value)
		{
			if (Value != null)
			{
				if (dicSource.ContainsKey(Value))
					return dicSource[Value].ToString();
				else
					return Value.ToString();
			}
			else
				return "N/A";
		}

		public string SafeToAppend(string strSource, string strLeft, string strRight)
		{
			string strReturn = strSource;
			if (SafeToLength(strReturn) > 0)
			{
				strReturn = strLeft + strReturn + strRight;
			}
			return strReturn;
		}

		public int SafeToLength(string strValue)
		{
			if (!string.IsNullOrWhiteSpace(strValue))
				return strValue.Length;
			else
				return 0;
		}
	}
}
