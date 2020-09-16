using Newtonsoft.Json;

namespace XShoppySharpUnitTest
{
    public class XShoppyShop
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("apikey")]
        public string Apikey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("shareSecret")]
        public string ShareSecret { get; set; }

    }
}
