using Newtonsoft.Json;

namespace XShoppySharp.Entities.Address
{
    public class XShoppyAddressData
    {
        /// <summary>
        /// 用户绑定地址
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }
        /// <summary>
        /// 用户绑定的详细地址
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }
        /// <summary>
        /// 用户绑定城市
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }
        /// <summary>
        /// 用户绑定公司
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }
        /// <summary>
        /// 用户绑定国家
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }
        /// <summary>
        /// 用户绑定国家简称
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
        /// <summary>
        /// 用户绑定姓氏
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        /// <summary>
        /// 用户绑定名字
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }
        /// <summary>
        /// 用户绑定全名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// 用户绑定手机号
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
        /// <summary>
        /// 用户邮箱地址
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
        /// <summary>
        /// 用户绑定城市
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }
        /// <summary>
        /// 用户绑定城市简称
        /// </summary>
        [JsonProperty("province_code")]
        public string ProvinceCode { get; set; }
        /// <summary>
        /// 用户绑定邮编
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }
        /// <summary>
        /// 税号
        /// </summary>
        [JsonProperty("tax_number")]
        public string TaxNumber { get; set; }
    }
}
