using Newtonsoft.Json;

namespace XShoppySharp.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class XShoppyObject<T>
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("now")]
        public string Now { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
