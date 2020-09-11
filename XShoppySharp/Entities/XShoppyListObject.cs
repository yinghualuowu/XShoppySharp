using System.Collections.Generic;
using Newtonsoft.Json;

namespace XShoppySharp.Entities
{
    /// <summary>
    /// 返回列表数据
    /// </summary>
    /// <typeparam name="T">列表中保存的实体</typeparam>
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

        /// <summary>
        /// 保存列表
        /// </summary>
        [JsonProperty("data")]
        public List<T> DataList { get; set; }

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

                var pageInt = totalCount / limit;

                var pageMode = totalCount % limit == 0 ? 0 : 1;

                var totalPage = pageInt + pageMode;

                return totalPage > CurrentPage;
            }
            
        }
    }
}