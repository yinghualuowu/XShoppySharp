using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using XShoppySharp.Common;
using XShoppySharp.Exception;

namespace XShoppySharp
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class XShoppySharpService
    {
        /// <summary>
        /// API接口版本
        /// </summary>
        public string APIVersion = "0.6.3";

        private readonly string _shareSecret;

        private XShoppyHttpClient Client { get; }

        private string OpenApi => "https://openapi.xshoppy.shop";

        /// <summary>
        /// 创建私有接口对接方式
        /// </summary>
        /// <param name="apiKey">API Key</param>
        /// <param name="password">API Password</param>
        /// <param name="shareSecret">共享秘钥</param>
        protected XShoppySharpService(string apiKey,string password,string shareSecret)
        {
            _shareSecret = shareSecret;

            Client = new XShoppyHttpClient(apiKey,password);
        }

        /// <summary>
        /// 对外做出Get请求
        /// </summary>
        /// <param name="path">请求接口路由</param>
        /// <param name="parameters">查询参数</param>
        /// <returns></returns>
        protected async Task<T> GetExecuteRequest<T>(string path,string parameters = "")
        {
            var req = new Uri($"{OpenApi}{path}{parameters}");
            return await ExecuteRequest<T>(req, HttpMethod.Get);
        }

        /// <summary>
        /// 对外做出请求
        /// </summary>
        /// <param name="uri">请求接口</param>
        /// <param name="method">请求方式</param>
        /// <returns>返回实体对象<see cref="T"/></returns>
        private async Task<T> ExecuteRequest<T>(Uri uri,HttpMethod method)
        {
            using (var requestMessage = BuildHttpRequestMessage(uri,method))
            {
                var response = await Client.SendAsync(requestMessage);

                var rawResult = await response.Content.ReadAsStringAsync();

                //检查返回值
                CheckResponseExceptions(response, rawResult);

                var result = JsonConvert.DeserializeObject<T>(rawResult);

                return result;
            }
        }

        /// <summary>
        /// 组合一个HttpRequestMessage，内部包含"X-SAIL-ACCESS-TOKEN
        /// </summary>
        /// <param name="uri">请求接口</param>
        /// <param name="method">请求方式</param>
        /// <returns>返回一个<see cref="HttpRequestMessage"/></returns>
        private HttpRequestMessage BuildHttpRequestMessage(Uri uri, HttpMethod method)
        {
            var requestMessage = new HttpRequestMessage(method,uri);

            if (!string.IsNullOrEmpty(_shareSecret))
            {
                requestMessage.Headers.Add("X-SAIL-ACCESS-TOKEN", _shareSecret);
            }

            requestMessage.Headers.Add("Accept", "application/json");

            return requestMessage;
        }

        /// <summary>
        /// 检查对应返回码和返回值，并抛出对应异常
        /// </summary>
        /// <param name="response">返回信息</param>
        /// <param name="rawResult">返回正文</param>
        private void CheckResponseExceptions(HttpResponseMessage response, string rawResult)
        {
            var httpCode = response.StatusCode;

            if ((int)httpCode >= 200 && (int)httpCode < 300)
            {
                return;
            }

            //接口限频
            if ((int) httpCode == 429)
            {
                throw new XShoppySharpRateLimitException(httpCode,rawResult);
            }

            throw new XShoppySharpException(httpCode,rawResult);
        }
    }
}
