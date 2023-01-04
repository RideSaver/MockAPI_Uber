using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using UberAPI.Models;

namespace UberAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    { 
        [HttpPost]
        [Route("request")]
        public IActionResult PostRequest([FromBody]Requests body)
        { 
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("/request/{request_id}")]
        public IActionResult DeleteRequest([FromRoute][Required]string requestId)
        { 
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/request/{request_id}")]
        public IActionResult GetRequest([FromRoute][Required]string requestId)
        {
            throw new NotImplementedException();
        }

        [HttpPatch]
        [Route("/request/{request_id}")]
        public IActionResult PatchRequest([FromRoute][Required]string requestId)
        { 
            throw new NotImplementedException();
        }
    }
}
