using UberAPI.Interface;
using UberAPI.Models;
using UberAPI.Registry;

namespace UberAPI.Repository
{
    public class EstimateRepository : IEstimateRepository
    {
        public List<PriceEstimate> GetPriceEstimates(LatLng startLocation, LatLng endLocation)
        {
            List<PriceEstimate> priceEstimateList = PriceEstimateGenerator.GeneratePriceEstimate(10);
            return priceEstimateList;
        }

        public List<TimeEstimate> GetTimeEstimates(LatLng startLocation, LatLng endLocation)
        {
            List<TimeEstimate> timeEstimateList = TimeEstimateGenerator.GenerateTimeEstimate(10);
            return timeEstimateList;
        }
    }
}
