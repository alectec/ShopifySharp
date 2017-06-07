using Machine.Specifications;
using System.Collections.Generic;

namespace ShopifySharp.Tests.ShopifyAbandonedCartService_Tests
{
    [Subject(typeof(ShopifyAbandonedCartService))]
    class when_counting_checkouts
    {
        Establish context = () =>
        {
            Service = new ShopifyAbandonedCartService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Result = Service.CountAsync().Await().AsTask.Result;
        };

        It should_count_checkouts = () =>
        {
            Result.ShouldBeGreaterThanOrEqualTo(1);
        };


        Cleanup after = () =>
        {

        };

        static ShopifyAbandonedCartService Service;

        static List<ShopifyAbandonedCheckout> Created = new List<ShopifyAbandonedCheckout>();

        static int Result;
    }
}
