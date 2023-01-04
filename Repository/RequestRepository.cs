using UberAPI.Interface;
using UberAPI.Models;
using UberAPI.Registry;

namespace UberAPI.Repository
{
    public class RequestRepository : IRequestRepository
    {
        public void DeleteRequest(string requestId)
        {
            throw new NotImplementedException();
        }

        public RequestId GetRequest(string requestId)
        {
            RequestId request = RequestGenerator.GenerateRequest();
            return request; 
        }

        public void PatchRequest(string requestId)
        {
            throw new NotImplementedException();
        }

        public void PostRequest(Requests body)
        {
            throw new NotImplementedException();
        }
    }
}
