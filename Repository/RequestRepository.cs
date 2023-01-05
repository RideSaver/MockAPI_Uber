using UberAPI.Interface;
using UberAPI.Models;
using UberAPI.Registry;

namespace UberAPI.Repository
{
    public class RequestRepository : IRequestRepository
    {
        public RequestId GetRequest(string requestId) => RequestGenerator.GenerateRequest();
        public async Task<RequestEstimateResponse> PostRequestEstimate(string requestId) =>  await Task.FromResult(EstimateGenerator.GenerateEstimate());
        public void DeleteRequest(string requestId) => throw new NotImplementedException();
        public void PatchRequest(string requestId) => throw new NotImplementedException();
        public void PostRequest(Requests body) => throw new NotImplementedException();
    }
}
