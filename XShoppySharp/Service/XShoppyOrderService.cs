using System.Threading.Tasks;
using XShoppySharp.Entities.Order;
using XShoppySharp.Extends;
using XShoppySharp.Filters;

namespace XShoppySharp.Service
{
    public class XShoppyOrderService: XShoppySharpService
    {
        public XShoppyOrderService(string apiKey, string password, string shareSecret) : base(apiKey, password, shareSecret)
        {

        }

        /// <summary>
        /// 获取订单列表
        /// </summary>
        /// <param name="filters">订单查询参数</param>
        /// <returns></returns>
        public async Task<XShoppyOrderList> GetOrderListAsync(XShoppyOrderFilters filters = null)
        {
            var result = await GetExecuteRequest<XShoppyOrderList>("/order/orders/list?",filters.ToQueryParameters());

            return result;
        }

        /// <summary>
        /// 获取获取数量
        /// </summary>
        /// <returns></returns>
        public async Task<XShoppyOrderCount> GetOrderCountAsync()
        {
            var result = await GetExecuteRequest<XShoppyOrderCount>("/order/orders/count");

            return result;
        }
    }
}
