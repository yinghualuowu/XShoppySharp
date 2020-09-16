using Newtonsoft.Json;
using XShoppySharp.Entities.Address;

namespace XShoppySharp.Entities.Order
{
    /// <summary>
    /// 更新订单部分信息请求
    /// </summary>
    public class XShoppyOrderReq
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 用户下单填写的email
        /// </summary>
        [JsonProperty("email",DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonProperty("tracking_number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// 物流发送时间
        /// </summary>
        [JsonProperty("fulfillment_send_time", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FulfillmentSendTime { get; set; }

        /// <summary>
        /// 物流状态 1.pending未发货 2.fulfilled已发货 3.abandoned 废弃的
        /// </summary>
        [JsonProperty("fulfillment_status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FulfillmentStatus { get; set; }

        /// <summary>
        /// 发货地址
        /// </summary>
        [JsonProperty("shipping", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public XShoppyAddressData Shipping { get; set; }
    }
}
