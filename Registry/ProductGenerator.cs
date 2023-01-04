using AutoBogus;
using Bogus;
using UberAPI.Helper;
using UberAPI.Models;

namespace UberAPI.Registry
{
    public static class ProductGenerator
    {
        public static Faker<ProductPriceDetails> PPD_FAKER_CONFIG = new Faker<ProductPriceDetails>()
            .RuleFor(o => o.CostPerMinute, f => f.Random.Float(0, 2))
            .RuleFor(o => o.DistanceUnit, () => "Mile")
            .RuleFor(o => o.Minimum, () => 3.50f)
            .RuleFor(o => o.CostPerDistance, () => 2.00f)
            .RuleFor(o => o.CanellationFee, () => 5.00f)
            .RuleFor(o => o.CurrencyCode, () => "USD");

        public static Product GenerateProduct()
        {
            var product = new Product()
            {
                UpfrontFareEnabled = false,
                Capacity= 4,
                ProductId = "PLACE-HOLDER",
                PriceDetails = PPD_FAKER_CONFIG.Generate(),
                Image = "",
                CashEnabled = false,
                Shared = false,
                ShortDescription = "RideShare Service",
                DisplayName = DataPool.NamePool.Random(),
                ProductGroup = "RideShare",
                Description = "RideShare Ride",
            };

            return product;
        }

        public static ProductList GenerateProducts(int repeat)
        {
            var products = new ProductList();
            for(int i = 0; i < repeat; i++)
            {
                var product = GenerateProduct();
                products.Products.Add(product);
            }

            return products;    
        }
    }
}
