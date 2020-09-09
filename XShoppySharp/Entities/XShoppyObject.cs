using Newtonsoft.Json;

namespace XShoppySharp.Entities
{
    public class XShoppyObject<T>
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("now")]
        public string Now { get; set; }

        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
