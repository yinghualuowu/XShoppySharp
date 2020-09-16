using Newtonsoft.Json;
using System.Collections.Generic;
using XShoppySharp.Entities.Address;
using XShoppySharp.Entities.Product;

namespace XShoppySharp.Entities.Order
{
    /// <summary>
    /// 订单服务列表返回实体
    /// </summary>
    public class XShoppyOrderListData : XShoppyListObject<XShoppyOrderData>
    {

    }

    /// <summary>
    /// 订单实体
    /// </summary>
    public class XShoppyOrderData
    {
        /// <summary>
        /// 店铺访问URL
        /// </summary>
        [JsonProperty("shop_url")]
        public string ShopUrl { get; set; }
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("app_id")]
        public long AppId { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// 在Sail平台的用户ID
        /// </summary>
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }
        /// <summary>
        /// 用户下单填写的email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
        /// <summary>
        /// 用户下单支付方式 1.credit card信用卡方式 2.paypal 3.cod
        /// </summary>
        [JsonProperty("gateway")]
        public string Gateway { get; set; }
        /// <summary>
        /// 所有订单项价格，包含折扣、运费的总和
        /// 关于价格计算
        /// total_price=subtotal_price+total_fulfillment-total_discounts+total_tax+shipping_insurance
        /// </summary>
        [JsonProperty("total_price")]
        public string TotalPrice { get; set; }
        /// <summary>
        /// 折后商品总价，不包含折扣
        /// </summary>
        [JsonProperty("subtotal_price")]
        public string SubtotalPrice { get; set; }
        /// <summary>
        /// 商品总重量
        /// </summary>
        [JsonProperty("total_weight")]
        public string TotalWeight { get; set; }
        /// <summary>
        /// 总税价
        /// </summary>
        [JsonProperty("total_tax")]
        public double TotalTax { get; set; }
        /// <summary>
        /// 物流总价
        /// </summary>
        [JsonProperty("total_fulfillment")]
        public string TotalFulfillment { get; set; }
        /// <summary>
        /// 付款单位
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
        /// <summary>
        /// 支付状态 1.unpaid订单未支付 2.voided订单支付失败 3. paid订单支付成功 4.pending 待支付 
        /// </summary>
        [JsonProperty("financial_status")]
        public string FinancialStatus { get; set; }
        /// <summary>
        /// 总优惠金额
        /// </summary>
        [JsonProperty("total_discounts")]
        public string TotalDiscounts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total_line_items_price")]
        public string TotalLineItemsPrice { get; set; }
        /// <summary>
        /// 下单用户IP
        /// </summary>
        [JsonProperty("browser_ip")]
        public string BrowserIp { get; set; }
        /// <summary>
        /// 订单号同id
        /// </summary>
        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }
        /// <summary>
        /// 订单名称
        /// </summary>
        [JsonProperty("order_name")]
        public string OrderName { get; set; }
        /// <summary>
        /// 支付时间
        /// </summary>
        [JsonProperty("pay_time")]
        public string PayTime { get; set; }
        /// <summary>
        /// 支付类型，具体的支付渠道，类似于paypal
        /// </summary>
        [JsonProperty("pay_type")]
        public string PayType { get; set; }
        /// <summary>
        /// 第三方交易平台交易流水号
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
        /// <summary>
        /// 订单详情交易地址
        /// </summary>
        [JsonProperty("order_status_url")]
        public string OrderStatusUrl { get; set; }
        /// <summary>
        /// 用户来源站（暂不支持)
        /// </summary>
        [JsonProperty("referring_site")]
        public string ReferringSite { get; set; }
        /// <summary>
        /// 用户来源页
        /// </summary>
        [JsonProperty("landing_site")]
        public string LandingSite { get; set; }
        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }
        /// <summary>
        /// 物流发送时间
        /// </summary>
        [JsonProperty("fulfillment_send_time")]
        public string FulfillmentSendTime { get; set; }
        /// <summary>
        /// 订单状态 1.init 初始化订单 2.pending 进行中订单 3.completed已完成订单 4.cancel取消订单 5.refunded(退款)    
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
        /// <summary>
        /// 物流状态 1.pending未发货 2.fulfilled已发货 3.any未知状态
        /// </summary>
        [JsonProperty("fulfillment_status")]
        public string FulfillmentStatus { get; set; }
        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        /// <summary>
        /// 订单更新时间
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
        /// <summary>
        /// paypal账单号
        /// </summary>
        [JsonProperty("checkout_id")]
        public string CheckoutId { get; set; }
        /// <summary>
        /// 佣金（默认值为0)
        /// </summary>
        [JsonProperty("commission")]
        public double Commission { get; set; }
        /// <summary>
        /// 选中的物流方案
        /// </summary>
        [JsonProperty("shipping_method")]
        public string ShippingMethod { get; set; }
        /// <summary>
        /// 订单备注（买家备注)
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }
        /// <summary>
        /// 运费险
        /// </summary>
        [JsonProperty("shipping_insurance")]
        public string ShippingInsurance { get; set; }

        /// <summary>
        /// 订单内产品
        /// </summary>
        [JsonProperty("products")]
        public List<XShoppyProductData> Products { get; set; }

        /// <summary>
        /// 买家地址
        /// </summary>
        [JsonProperty("billing")]
        public XShoppyAddressData Billing { get; set; }

        /// <summary>
        /// 发货地址
        /// </summary>
        [JsonProperty("shipping")]
        public XShoppyAddressData Shipping { get; set; }
    }

    /// <summary>
    /// 订单个数实体
    /// </summary>
    public class XShoppyOrderCountData
    {
        /// <summary>
        /// 订单个数
        /// </summary>
        [JsonProperty("count")]
        public string Count { get; set; }
    }
}
