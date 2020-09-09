using System.Threading.Tasks;
using XShoppySharp.Entities.Order;

namespace XShoppySharp.Service
{
    public class XShoppyOrderService: XShoppySharpService
    {
        public XShoppyOrderService(string apiKey, string password, string shareSecret) : base(apiKey, password, shareSecret)
        {

        }

        public async Task<XShoppyOrderList> GetOrderListAsync()
        {
            var result = await GetExecuteRequest<XShoppyOrderList>("/order/orders/list");

            return result;
        }

        public async Task<XShoppyOrderCount> GetOrderCountAsync()
        {
            var result = await GetExecuteRequest<XShoppyOrderCount>("/order/orders/count");

            return result;
        }
    }
}
