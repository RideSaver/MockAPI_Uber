using UberAPI.Helper;
using UberAPI.Models;

namespace UberAPI.Registry
{
    public class PriceEstimateGenerator
    {
        public static IEnumerable<int> HighEstimateRange = Enumerable.Range(50, 100); // Estimated Cost (maximum)
        public static IEnumerable<int> LowEstimateRange = Enumerable.Range(15, 50); // Estimated Cost (minimum)
        public static IEnumerable<int> DurationRange = Enumerable.Range(10, 50); // Estimated Duration
        public static IEnumerable<int> DistanceRange = Enumerable.Range(10, 50); // Estimated Distance

        public static string CurrencyCode = "USD"; // Currency (always USD)

        public static List<PriceEstimate> GeneratePriceEstimate(int repeat)
        {
            var PriceEstimates = new List<PriceEstimate>();
            for(int i = 0; i< repeat; i++)
            {
                var priceEstimate = new PriceEstimate()
                {
                    LocalizedDisplayName = DataPool.NamePool.Random(),
                    Distance = DistanceRange.Random(),
                    DisplayName = DataPool.NamePool.Random(),
                    ProductId = new Guid().ToString(),
                    HighEstimate = HighEstimateRange.Random(),
                    LowEstimate = LowEstimateRange.Random(),
                    Duration = DurationRange.Random(),
                    Estimate = "N/A",
                    SurgeMultiplier = 2,
                    CurrencyCode= CurrencyCode,
                };

                PriceEstimates.Add(priceEstimate);
            }

            return PriceEstimates;
        }
    }
}
