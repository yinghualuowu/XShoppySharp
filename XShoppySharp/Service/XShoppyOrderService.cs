using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XShoppySharp.Entities.Order;
using XShoppySharp.Extends;
using XShoppySharp.Filters;

namespace XShoppySharp.Service
{
    /// <summary>
    /// 
    /// </summary>
    public class XShoppyOrderService: XShoppySharpService
    {
        /// <summary>
        /// 订单服务
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="password"></param>
        /// <param name="shareSecret"></param>
        public XShoppyOrderService(string apiKey, string password, string shareSecret) : base(apiKey, password, shareSecret)
        {

        }

        /// <summary>
        /// 获取订单列表
        /// </summary>
        /// <param name="filters">订单查询参数</param>
        /// <returns></returns>
        public async Task<XShoppyOrderListResp> GetOrderListAsync(XShoppyOrderFilters filters = null)
        {
            var result = await GetExecuteRequest<XShoppyOrderListResp>("/order/orders/list?",filters.ToQueryParameters());

            return result;
        }

        /// <summary>
        /// 获取获取数量
        /// </summary>
        /// <returns></returns>
        public async Task<XShoppyOrderCountResp> GetOrderCountAsync()
        {
            var result = await GetExecuteRequest<XShoppyOrderCountResp>("/order/orders/count");

            return result;
        }

        /// <summary>
        /// 根据订单ID获取订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<XShoppyOrderResp> GetOrderByIdAsync(string id)
        {
            var result = await GetExecuteRequest<XShoppyOrderResp>("/order/orders?", $"id={id}");

            return result;
        }

        /// <summary>
        /// 更新部分订单
        /// </summary>
        /// <param name="xShoppyOrderReq">更新订单部分信息</param>
        /// <returns></returns>
        public async Task<XShoppyOrderUpdateResp> UpdateOrderAsync(XShoppyOrderReq xShoppyOrderReq)
        {
            var json = JsonConvert.SerializeObject(xShoppyOrderReq);

            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

            var result = await PutExecuteRequest<XShoppyOrderUpdateResp>("/order/orders/update", stringContent);

            return result;
        }
    }
}
