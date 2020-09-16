using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using XShoppySharp.Entities.Order;
using XShoppySharp.Exception;
using XShoppySharp.Filters;
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
                string text = System.IO.File.ReadAllText(@"E:\资料\XShoppy\Shop.json");

                var model = JsonConvert.DeserializeObject<XShoppyShop>(text);

                model.Apikey = "1";

                var order = new XShoppyOrderService(model.Apikey,
                    model.Password,
                    model.ShareSecret);

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

            Assert.False(resp.Data.DataList == null);
        }

        [Fact]
        public async Task OrderFiltersService()
        {
            string text = System.IO.File.ReadAllText(@"E:\资料\XShoppy\Shop.json");

            var model = JsonConvert.DeserializeObject<XShoppyShop>(text);

            var order = new XShoppyOrderService(model.Apikey,
                model.Password,
                model.ShareSecret);

            var filters = new XShoppyOrderFilters
            {
                TimeStart = DateTime.Now.AddDays(-3),
                TimeEnd = DateTime.Now
            };

            var resp = await order.GetOrderListAsync(filters);

            Assert.False(resp.Data.DataList == null);

            var current = resp.Data.CurrentPage;
            int.TryParse(resp.Data.TotalCount, out var totalCount);

            var result = totalCount > current;

            Assert.True(result == resp.Data.IsNextPage);
        }

        [Fact]
        public async Task OrderUpdateService()
        {
            bool result = false;

            try
            {
                string text = System.IO.File.ReadAllText(@"E:\资料\XShoppy\Shop.json");

                var model = JsonConvert.DeserializeObject<XShoppyShop>(text);

                var order = new XShoppyOrderService(model.Apikey,
                    model.Password,
                    model.ShareSecret);

                var req = new XShoppyOrderReq
                    { Id = "200909050655666", TrackingNumber = "LY451186937CN", FulfillmentStatus = "fulfilled" };

                var orderUpdate = await order.UpdateOrderAsync(req);
            }
            catch (Exception e)
            {
                result = true;
            }

            Assert.False(result);
        }
    }
}
