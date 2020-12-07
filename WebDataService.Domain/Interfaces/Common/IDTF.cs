using System;
using System.Collections.Generic;
using System.Text;

namespace WebDataService.Domain.Interfaces.Common
{
	public interface IDTF
	{
		/// <summary>
		/// 如傳入字串有值則在左右加上設定的字串
		/// </summary>
		/// <param name="strSource">傳入字串</param>
		/// <param name="strLeft">左字串</param>
		/// <param name="strRight">右字串</param>
		/// <returns></returns>
		string SafeToAppend(string strSource, string strLeft, string strRight);

		/// <summary>
		/// 取得字串長度
		/// </summary>
		/// <param name="strValue">字串</param>
		/// <returns></returns>
		int SafeToLength(string strValue);

		//string GetConfig(string strKey);

		/// <summary>
		/// 取得字典結果
		/// </summary>
		/// <typeparam name="T1">Dictionary.Key</typeparam>
		/// <typeparam name="T2">Dictionary.Value</typeparam>
		/// <param name="dicSource">Dictionary</param>
		/// <param name="Value">讀取值</param>
		/// <returns></returns>
		string GetResult<T1, T2>(Dictionary<T1, T2> dicSource, T1 Value);
	}
}
