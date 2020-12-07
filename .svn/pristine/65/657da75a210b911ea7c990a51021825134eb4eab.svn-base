using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebDataService.Domain.Interfaces.API;
using WebDataService.Domain.Interfaces.Common;

namespace WebDataService.DataLayer.Managers.API
{
	public class ApiManagers: IApiManagers
    {
        private IDTF _IDTF;

        public ApiManagers(IDTF IDTF)
        {
            this._IDTF = IDTF;
        }
        /// <summary>
        /// 呼叫api METHOD:GET
        /// </summary>
        /// <param name="strUrl">api url</param>
        /// <returns></returns>
        public Task<T> Get<T>(string strUrl)
        {
            var Result = GetAsync<T>(strUrl);
            return Result;
        }

        /// <summary>
        /// 呼叫api METHOD:POST
        /// </summary>
        /// <param name="strUrl">api url</param>
        /// <param name="csQueryParameter">Post data</param>
        /// <returns></returns>
        public Task<T> Post<T>(string strUrl, NameValueCollection csQueryParameter)
        {
            var Result = PostAsync<T>(strUrl, csQueryParameter);
            return Result;
        }

        #region private
        private async Task<T> GetAsync<T>(string strUrl)
        {
            using (WebClient webClient = new WebClient())
            {
                var Query = await webClient.DownloadDataTaskAsync(new Uri(strUrl));
                var Result = JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(Query));
                return Result;
            }
        }

        private async Task<T> PostAsync<T>(string strUrl, NameValueCollection csQueryParameter)
        {
            string strQueryParameter = string.Empty;
            string strResponse = string.Empty;
            if (csQueryParameter != null)
            {
                foreach (var item in csQueryParameter.AllKeys)
                {
                    strQueryParameter = this._IDTF.SafeToAppend(strQueryParameter, "", "&") + item + "=" + csQueryParameter[item];
                }
            }

            try
            {
                #region POST
                //https://sites.google.com/site/kerjininfostudiocsharp/08-chang-jian-wen-ti/02-window-form/002-shi-yongpost-mo-shi-qu-de-wang-ye-nei-rong
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(strUrl);//宣告並配置網站連線，設定網址

                req.Proxy = null;//設定後跑比較快     
                CookieContainer cc = new CookieContainer();//宣告並配置 Cookie
                req.CookieContainer = cc;//網站連線指定 Cookie

                req.Method = "POST";//以 POST 模式交付參數
                req.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.1.4322)";//瀏覽器的識別資訊
                req.ContentType = "application/x-www-form-urlencoded";//傳遞資料的類型             

                using (var streamWriter = new StreamWriter(req.GetRequestStream()))
                {
                    streamWriter.Write(strQueryParameter);
                    streamWriter.Flush();
                }

                //使用 GetResponseStream 方法從 server 回應中取得資料，stream 必需被關閉
                //使用 stream.close 就可以直接關閉 WebResponse 及 stream，但同時使用 using 或是關閉兩者並不會造成錯誤，養成習慣遇到其他情境時就比較不會出錯

                using (var httpResponse = (HttpWebResponse)req.GetResponse())
                {
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        strResponse = await streamReader.ReadToEndAsync();
                    }
                }

                req = null;

                #endregion
            }
            catch (Exception ex)
            {
                //this._functionerror.Write(ex.Message);
                throw new Exception(ex.Message);

                //return "error";
            }
            var Result = JsonConvert.DeserializeObject<T>(strResponse);
            return Result;

        }
        #endregion
    }
}
