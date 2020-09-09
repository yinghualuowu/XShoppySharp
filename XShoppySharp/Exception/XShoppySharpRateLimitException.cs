using System.Net;

namespace XShoppySharp.Exception
{
    public class XShoppySharpRateLimitException:XShoppySharpException
    {
        public XShoppySharpRateLimitException(HttpStatusCode httpStatusCode,string message) : base(httpStatusCode,message)
        {

        }
    }
}
