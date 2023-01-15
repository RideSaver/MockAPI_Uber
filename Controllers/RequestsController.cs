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
        [Route("/request/{request_id}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetRequest(string request_id)
        {
            _logger.LogInformation("[UberAPI:RequestsController:GetRequest] Controller endpoint invoked..");
            _logger.LogInformation($"[UberAPI:RequestsController:GetRequest] Data Received: Request ID: {request_id}");

            var requestInstance = await _requestsRepository.GetRequest(request_id);
            requestInstance._RequestId = request_id.ToString();

            _logger.LogInformation($"[UberAPI:RequestsController:GetRequest] Returning (RequestId) to the client... \n{requestInstance}");

            return Content(requestInstance.ToJson(), "application/json");
        }

        [HttpPost]
        [Route("/request")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> PostRequest([FromBody] CreateRequests body)
        {
            _logger.LogInformation("[UberAPI:RequestsController:PostRequest] Controller endpoint invoked..");

            if (body is null) { return BadRequest("Invalid request data!"); }

            var rideRequest = new CreateRequests()
            {
                FareId = body.FareId.ToString(),
                ProductId = body.ProductId.ToString(),
                StartLatitude = body.StartLatitude,
                EndLatitude = body.EndLatitude,
                StartLongitude = body.StartLongitude,
                EndLongitude = body.EndLongitude,
                SurgeConfirmationId = body.SurgeConfirmationId,
                PaymentMethodId = body.PaymentMethodId,
                Seats = body.Seats
            };

            _logger.LogInformation($"[UberAPI:RequestsController:PostRequest] Instance (CreateRequest) received from the client... \n{rideRequest}");

            var requestInstance = await _requestsRepository.PostRequest(body);
            requestInstance.ProductId = body.ProductId!.ToString();

            _logger.LogInformation($"[UberAPI:RequestsController:PostRequest] Returning (RequestId) to the client... \n{requestInstance}");

            return Content(requestInstance.ToJson(), "application/json");
        }

        [HttpPost]
        [Route("/requests/estimate")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public async Task<ActionResult<RequestEstimateResponse>> PostRequestEstimate([FromBody] RequestEstimate requestBody)
        {
            if (requestBody is null) return BadRequest("Error: Invalid data receieved (null)");

            var estimate = await _requestsRepository.PostRequestEstimate(requestBody.ProductId!);

            return Content(estimate.ToJson(), "application/json");
        }

        [HttpDelete]
        [Route("/request/{request_id}")]
        public async Task<IActionResult> DeleteRequest(string request_id) => await Task.FromResult(new NoContentResult());
    }
}
