using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XShoppySharp.Entities.Product
{
    public class XShoppyProductData
    {
        /// <summary>
        /// 订单商品id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
        /// <summary>
        /// 子商品id
        /// </summary>
        [JsonProperty("variant_id")]
        public long VariantId { get; set; }
        /// <summary>
        /// 商品标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        /// <summary>
        /// 商品价格
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }
        /// <summary>
        /// 商品sku
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sku_utm")]
        public string SkuUtm { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("product_id")]
        public long ProductId { get; set; }
        /// <summary>
        /// sku名称
        /// </summary>
        [JsonProperty("attr_name")]
        public string AttrName { get; set; }
        /// <summary>
        /// url链接
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
        /// <summary>
        /// 商品默认图地址
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// 订单商品
        /// </summary>
        [JsonProperty("properties")]
        public List<PropertyData> Properties { get; set; }
    }

    public class PropertyData
    {
        /// <summary>
        /// 属性名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
