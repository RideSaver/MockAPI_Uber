using UberAPI.Models;

namespace UberAPI.Interface
{
    public interface IEstimateRepository
    {
        List<PriceEstimate> GetPriceEstimates(LatLng startLocation, LatLng endLocation);
        List<TimeEstimate> GetTimeEstimates(LatLng startLocation, LatLng endLocation);
    }
}
