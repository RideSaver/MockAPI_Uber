using UberAPI.Models;

namespace UberAPI.Interface
{
    public interface IRequestRepository
    {
        Task<RequestId> PostRequest(CreateRequests request);
        void DeleteRequest(string requestId);
        RequestId GetRequest(string requestId);
        void PatchRequest(string requestId);
        Task<RequestEstimateResponse> PostRequestEstimate(string requestId);
    }
}
