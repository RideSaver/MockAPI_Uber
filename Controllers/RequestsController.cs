using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using UberAPI.Filters;
using UberAPI.Interface;
using UberAPI.Models;

namespace UberAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequestsController : ControllerBase
    {
        private readonly IRequestRepository _requestsRepository;
        private readonly ILogger<RequestsController> _logger;

        public RequestsController(IRequestRepository requestsRepository, ILogger<RequestsController> logger)
        {
            _requestsRepository = requestsRepository;
            _logger = logger;
        }

        [HttpGet]
        [Route("/requests/{request_id}")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult GetRequest([FromRoute][Required] string requestId)
        {
            _logger.LogInformation("[UberAPI:RequestsController:GetRequest] Controller endpoint invoked..");
            _logger.LogInformation($"[UberAPI:RequestsController:GetRequest] Data Received: Request ID: {requestId}");

            return new OkObjectResult(_requestsRepository.GetRequest(requestId));
        }

        [HttpPost]
        [Route("/requests/estimate")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public async Task<ActionResult<RequestEstimateResponse>> PostRequestEstimate([FromBody] RequestEstimate requestBody)
        {
            if (requestBody is null) return BadRequest("Error: Invalid data receieved (null)");

            _logger.LogInformation("[UberAPI:RequestsController:PostRequestEstimate] Controller endpoint invoked..");
            _logger.LogInformation($"[UberAPI:RequestsController:PostRequestEstimate] Data Received: Product ID: {requestBody.ProductId}");
            _logger.LogInformation($"[UberAPI:RequestsController:PostRequestEstimate] Data Received: Start long & lat: {requestBody.StartLongitude}-{requestBody.StartLatitude}");
            _logger.LogInformation($"[UberAPI:RequestsController:PostRequestEstimate] Data Received: End long & lat: {requestBody.EndLongitude}-{requestBody.EndLatitude}");

            var estimate = await _requestsRepository.PostRequestEstimate(requestBody.ProductId!);

            return Content(estimate.ToJson(), "application/json");
        }

        [HttpPost][Route("/requests/request")] 
        public IActionResult PostRequest([FromBody] Requests requestInfo) => new NoContentResult();

        [HttpDelete][Route("/requests/{request_id}")]
        public IActionResult DeleteRequest([FromRoute][Required] string requestId) => new NoContentResult();

        [HttpPatch][Route("/requests/{request_id}")]
        public IActionResult PatchRequest([FromRoute][Required] string requestId) => new NoContentResult();
    }
}
