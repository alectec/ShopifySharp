using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Tests.ShopifyAbandonedCartService_Tests.Test_Data
{
    public static class CheckoutCreation
    {
        public static IEnumerable<ShopifyAbandonedCheckout> CreateCheckouts()
        {
            var json = System.IO.File.ReadAllText("checkout.json");

            var checkouts = JsonConvert.DeserializeObject(json, typeof(List<ShopifyAbandonedCheckout>));

            return checkouts as List<ShopifyAbandonedCheckout>;
        }
        
        
    }
}
