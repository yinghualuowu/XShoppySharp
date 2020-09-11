using Newtonsoft.Json;

namespace XShoppySharp.Filters
{
    public abstract class XShoppyBaseFilters
    {
        /// <summary>
        /// 当前第几页
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// 最大获取数量
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; } = 20;

        public virtual XShoppyBaseFilters NextPage()
        {
            Page++;
            return this;
        }
    }
}
