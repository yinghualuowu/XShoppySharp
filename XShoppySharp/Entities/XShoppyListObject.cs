using System.Collections.Generic;
using Newtonsoft.Json;

namespace XShoppySharp.Entities
{
    public class XShoppyListObject<T>
    {
        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("totalCount")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [JsonProperty("currentPage")]
        public int CurrentPage { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("data")]
        public List<T> Data { get; set; }

        /// <summary>
        /// 是否存在下一页
        /// </summary>
        public bool IsNextPage
        {
            get
            {
                var limitResult = int.TryParse(Limit, out var limit);

                int.TryParse(TotalCount, out var totalCount);

                if (limitResult == false) return false;

                var totalPage = totalCount / limit + totalCount % limit == 0 ? 0 : 1;

                return totalPage <= CurrentPage;
            }
        }
    }
}