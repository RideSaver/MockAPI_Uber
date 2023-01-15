using UberAPI.Interface;
using UberAPI.Models;
using UberAPI.Registry;

namespace UberAPI.Repository
{
    public class RequestRepository : IRequestRepository
    {
        public async Task<RequestId> PostRequest(CreateRequests request)
        {
            return await Task.FromResult(RequestGenerator.GenerateRequest());
        }
        public async Task<RequestId> GetRequest(string requestId)
        {
            return await Task.FromResult(RequestGenerator.GenerateRequest());
        }
        public async Task<RequestEstimateResponse> PostRequestEstimate(string requestId)
        {
            return await Task.FromResult(EstimateGenerator.GenerateEstimate());
        }

        public void DeleteRequest(string requestId) => throw new NotImplementedException();
        public void PatchRequest(string requestId) => throw new NotImplementedException();
    }
}
