using UberAPI.Interface;
using UberAPI.Models;
using UberAPI.Registry;

namespace UberAPI.Repository
{
    public class RequestRepository : IRequestRepository
    {
        public RequestId GetRequest(string requestId) => RequestGenerator.GenerateRequest();
        public RequestEstimateResponse PostRequestEstimate(string requestId) => new RequestEstimateResponse(EstimateGenerator.GenerateEstimateWithoutSurge());
        public void DeleteRequest(string requestId) => throw new NotImplementedException();
        public void PatchRequest(string requestId) => throw new NotImplementedException();
        public void PostRequest(Requests body) => throw new NotImplementedException();
    }
}
