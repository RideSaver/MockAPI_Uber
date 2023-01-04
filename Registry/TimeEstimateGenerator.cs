using UberAPI.Helper;
using UberAPI.Models;

namespace UberAPI.Registry
{
    public static class TimeEstimateGenerator
    {
        public static IEnumerable<int> EstimateRange = Enumerable.Range(50, 150); // Estimated Cost (minimum)
        public static List<TimeEstimate> GenerateTimeEstimate(int repeat)
        {
            var TimeEstimates = new List<TimeEstimate>();
            for (int i = 0; i < repeat; i++)
            {
                var timeEstimate = new TimeEstimate()
                {
                    LocalizedDisplayName = DataPool.NamePool.Random(),
                    DisplayName = DataPool.NamePool.Random(),
                    ProductId = new Guid().ToString(),
                    Estimate = EstimateRange.Random()
                };

                TimeEstimates.Add(timeEstimate);
            }

            return TimeEstimates;
        }
    }
}
