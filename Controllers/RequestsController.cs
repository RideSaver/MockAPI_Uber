using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
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
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(EstimateWithSurge), 200)]
        [ProducesResponseType(typeof(EstimateWithoutSurge), 200)]
        public async Task<IActionResult> PostRequestEstimate([FromBody] RequestEstimate requestBody)
        {
            if (requestBody is null) return BadRequest("Error: Invalid data receieved (null)");

            var requestEstimate = new RequestEstimate()
            {
                ProductId = requestBody.ProductId,
                StartLatitude= requestBody.StartLatitude,
                StartLongitude= requestBody.StartLongitude,
                StartPlaceId= requestBody.StartPlaceId,
                EndLatitude= requestBody.EndLatitude,
                EndLongitude= requestBody.EndLongitude,
                EndPlaceId= requestBody.EndPlaceId,
                SeatCount= requestBody.SeatCount,
            };

            _logger.LogInformation("[UberAPI:RequestsController:PostRequestEstimate] Controller endpoint invoked..");
            _logger.LogInformation($"[UberAPI:RequestsController:PostRequestEstimate] Data Received: Product ID: {requestEstimate.ProductId}");
            _logger.LogInformation($"[UberAPI:RequestsController:PostRequestEstimate] Data Received: Start long & lat: {requestEstimate.StartLongitude}-{requestEstimate.StartLatitude}");
            _logger.LogInformation($"[UberAPI:RequestsController:PostRequestEstimate] Data Received: End long & lat: {requestEstimate.EndLongitude}-{requestEstimate.EndLatitude}");

            var estimate = await _requestsRepository.PostRequestEstimate(requestEstimate.ProductId!);

            return new JsonResult(estimate.ToJson());
        }

        [HttpPost]
        [Route("/requests/request")]
        public IActionResult PostRequest([FromBody] Requests requestInfo) => new NoContentResult();

        [HttpDelete]
        [Route("/requests/{request_id}")]
        public IActionResult DeleteRequest([FromRoute][Required] string requestId) => new NoContentResult();

        [HttpPatch]
        [Route("/requests/{request_id}")]
        public IActionResult PatchRequest([FromRoute][Required] string requestId) => new NoContentResult();
    }
}
