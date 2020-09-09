using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace XShoppySharp.Common
{
    public class XShoppyHttpClient:HttpClient
    {
        /// <summary>
        /// 创建带有Basic Auth验证的HttpClient
        /// </summary>
        /// <param name="username">API Key</param>
        /// <param name="password">PI Password</param>
        public XShoppyHttpClient(string username, string password)
        {
            DefaultRequestHeaders.Authorization = Create(username, password);
        }

        private AuthenticationHeaderValue Create(string username, string password)
        {
            string credentials = $"{username}:{password}";
            var byteCredentials = Encoding.ASCII.GetBytes(credentials);
            var base64Credentials = Convert.ToBase64String(byteCredentials);

            return new AuthenticationHeaderValue("Basic", base64Credentials);
        }
    }
}
