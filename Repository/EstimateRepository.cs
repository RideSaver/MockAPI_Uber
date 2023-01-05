using UberAPI.Interface;
using UberAPI.Models;
using UberAPI.Registry;

namespace UberAPI.Repository
{
    public class EstimateRepository : IEstimateRepository
    {
        public List<PriceEstimate> GetPriceEstimates(LatLng startLocation, LatLng endLocation) => PriceEstimateGenerator.GeneratePriceEstimate(10);
        public List<TimeEstimate> GetTimeEstimates(LatLng startLocation, LatLng endLocation) => TimeEstimateGenerator.GenerateTimeEstimate(10);
    }
}
