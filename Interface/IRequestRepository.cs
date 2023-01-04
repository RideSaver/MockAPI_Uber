using UberAPI.Models;

namespace UberAPI.Interface
{
    public interface IRequestRepository
    {
        void PostRequest(Requests body);
        void DeleteRequest(string requestId);
        RequestId GetRequest(string requestId);
        void PatchRequest(string requestId);
    }
}
