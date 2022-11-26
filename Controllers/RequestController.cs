using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using UberAPI.Model;

namespace UberAPI.Controllers
{
    [ApiController]
    public class RequestController : ControllerBase
    {
        [HttpPost]
        [Route("/uber/api/request")]
        public Task<IActionResult> PostRequest([FromBody]Request request) 
        {
            // RETURNS: 202 (Accepted) 400 (Bad Request)
            // RETURNS: 403 (Missing Information or product not found)
            // RETURNS: 409 (Missing payment method, surge, fare expired, or retry request
            // RETURNS: 422:(Invalid fair Id, Validation failed, Same pickup/dropoff, destination required
            // REETURNS 500: Internal Server Error

            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/uber/api/request/{request_id}")]
        public Task<IActionResult> GetRequest([FromRoute(Name = "request_id")][Required] Guid requestId)
        {
            // RETURNS: 202 - ongoing trip information

            throw new NotImplementedException();
        }


        [HttpPatch]
        [Route("/uber/api/request/{request_id}")]
        public Task<IActionResult> PatchRequest([FromRoute(Name = "request_id")][Required] Guid requestId)
        {
            // RETURNS: 204 NO CONTENT
            // RETURNS: 401 Invalid cred provided
            // RETURNS: 404 RequestID doesn't exist
            // RETURNS: 422 Input failed validation

            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("/uber/api/request/{request_id}")]
        public Task<IActionResult> DeleteRequest([FromRoute(Name = "request_id")][Required] string requestId)
        {
            // RETURNS: 204 NO CONTENT

            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/uber/api/requests/{request_id}/map")]
        public Task<IActionResult> GetRequestMap([FromRoute(Name = "request_id")][Required] string requestId)
        {
            // RETURNS: 200 OK

            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/uber/api/requests/{request_id}/receipt")]
        public Task<IActionResult> GetRequestReceipt([FromRoute(Name = "request_id")][Required]string requestId)
        {
            // RETURNS: 200 OK

            throw new NotImplementedException();
        }


    }
}
