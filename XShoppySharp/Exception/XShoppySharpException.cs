using System.Net;

namespace XShoppySharp.Exception
{
    /// <summary>
    /// XShoppy异常基类
    /// </summary>
    public class XShoppySharpException : System.Exception
    {
        public HttpStatusCode HttpStatusCode { get; }

        public XShoppySharpException(string message) : base(message)
        {
            
        }

        public XShoppySharpException(HttpStatusCode httpStatusCode,string message) : base(message)
        {
            HttpStatusCode = httpStatusCode;
        }
    }
}
