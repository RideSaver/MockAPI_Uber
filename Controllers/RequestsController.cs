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

        [HttpPost]
        [Route("request")]
        public IActionResult PostRequest([FromBody]Requests body)
        {
            return new NoContentResult();
        }

        [HttpDelete]
        [Route("/request/{request_id}")]
        public IActionResult DeleteRequest([FromRoute][Required]string requestId)
        {
            return new NoContentResult();
        }

        [HttpGet]
        [Route("/request/{request_id}")]
        public IActionResult GetRequest([FromRoute][Required]string requestId)
        {
            return new OkObjectResult(_requestsRepository.GetRequest(requestId));
        }

        [HttpPatch]
        [Route("/request/{request_id}")]
        public IActionResult PatchRequest([FromRoute][Required]string requestId)
        {
            return new NoContentResult();
        }
    }
}
