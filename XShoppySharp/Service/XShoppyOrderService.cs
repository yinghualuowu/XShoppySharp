using System.Threading.Tasks;
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
        public async Task<XShoppyOrderListResp> GetOrderListAsync<T>(XShoppyOrderFilters filters = null)
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
    }
}
