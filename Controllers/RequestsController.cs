using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using UberAPI.Interface;
using UberAPI.Models;

namespace UberAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
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
        public IActionResult GetRequest([FromRoute][Required] string requestId)
        {
            _logger.LogInformation("[UberAPI:RequestsController:GetRequest] Controller endpoint invoked..");
            _logger.LogInformation($"[UberAPI:RequestsController:GetRequest] Data Received: Request ID: {requestId}");

            return new OkObjectResult(_requestsRepository.GetRequest(requestId));
        }

        [HttpPost]
        [Route("/requests/estimate")]
        public IActionResult PostRequestEstimate([FromBody] string productId, double startLat, double startLong, string? startPlaceId,
            double endLat, double endLong, string? endPlaceId, int? seats)
        {
            _logger.LogInformation("[UberAPI:RequestsController:PostRequestEstimate] Controller endpoint invoked..");
            _logger.LogInformation($"[UberAPI:RequestsController:PostRequestEstimate] Data Received: Product ID: {productId}");
            _logger.LogInformation($"[UberAPI:RequestsController:PostRequestEstimate] Data Received: Start long & lat: {startLong}-{startLat}");
            _logger.LogInformation($"[UberAPI:RequestsController:PostRequestEstimate] Data Received: End long & lat: {endLong}-{endLat}");

            return new OkObjectResult(_requestsRepository.PostRequestEstimate(productId));
        }

        [HttpPost]
        [Route("request")]
        public IActionResult PostRequest([FromBody] Requests requestInfo) => new NoContentResult();

        [HttpDelete]
        [Route("/requests/{request_id}")]
        public IActionResult DeleteRequest([FromRoute][Required] string requestId) => new NoContentResult();

        [HttpPatch]
        [Route("/requests/{request_id}")]
        public IActionResult PatchRequest([FromRoute][Required] string requestId) => new NoContentResult();
    }
}
