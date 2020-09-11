using Newtonsoft.Json;
using System;

namespace XShoppySharp.Filters
{
    /// <summary>
    /// 
    /// </summary>
    public class XShoppyOrderFilters: XShoppyBaseFilters
    {
        /// <summary>
        /// 创建时间 - 传递给平台会转为Unix时间戳
        /// </summary>
        [JsonProperty("time_start")]
        public DateTime? TimeStart { get; set; }

        /// <summary>
        /// 创建时间 - 传递给平台会转为Unix时间戳
        /// </summary>
        [JsonProperty("time_end")]
        public DateTime? TimeEnd { get; set; }

        /// <summary>
        /// 订单的最早更新时间 - 传递给平台会转为Unix时间戳
        /// </summary>
        [JsonProperty("update_time_start")]
        public DateTime? UpdateTimeStart { get; set; }

        /// <summary>
        /// 订单的最后更新时间 - 传递给平台会转为Unix时间戳
        /// </summary>
        [JsonProperty("update_time_end")]
        public DateTime? UpdateTimeEnd{ get; set; }

        /// <summary>
        /// 订单的最早支付时间 - 传递给平台会转为Unix时间戳
        /// </summary>
        [JsonProperty("pay_time_start")]
        public DateTime? PayTimeStart { get; set; }

        /// <summary>
        /// 订单的最后支付时间 - 传递给平台会转为Unix时间戳
        /// </summary>
        [JsonProperty("pay_time_end")]
        public DateTime? PayTimeEnd { get; set; }

        /// <summary>
        /// init 初始化订单，pending 进行中的订单 complete 已完成订单 cancel 取消订单
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付状态 unpaid订单未支付 voided订单支付失败 paid订单支付成功
        /// </summary>
        [JsonProperty("financial_status")]
        public string FinancialStatus { get; set; }
    }
}
