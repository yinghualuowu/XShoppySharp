using Newtonsoft.Json;
using System.Threading.Tasks;
using XShoppySharp.Exception;
using XShoppySharp.Service;
using Xunit;
using Assert = Xunit.Assert;

namespace XShoppySharpUnitTest
{
    public class OrderServer
    {
        [Fact]
        public async Task InitOrderService()
        {
            bool result = false;

            try
            {
                var order = new XShoppyOrderService("1","2","3");

                var resp = await order.GetOrderListAsync();
            }
            catch (XShoppySharpException e)
            {
                result = true;
            }

            Assert.True(result);
        }

        [Fact]
        public async Task OrderCountService()
        {
            string text = System.IO.File.ReadAllText(@"E:\资料\XShoppy\Shop.json");

            var model = JsonConvert.DeserializeObject<XShoppyShop>(text);

            var order = new XShoppyOrderService(model.Apikey,
                model.Password,
                model.ShareSecret);

            var resp = await order.GetOrderCountAsync();

            Assert.False(string.IsNullOrEmpty(resp.Data.Count));
        }

        [Fact]
        public async Task OrderEntitiesService()
        {
            string text = System.IO.File.ReadAllText(@"E:\资料\XShoppy\Shop.json");

            var model = JsonConvert.DeserializeObject<XShoppyShop>(text);

            var order = new XShoppyOrderService(model.Apikey,
                model.Password,
                model.ShareSecret);

            var resp = await order.GetOrderListAsync();

            Assert.False(resp.Data.Data == null);
        }
    }
}
