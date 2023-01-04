using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace UberAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EstimatesController : ControllerBase
    { 
        [HttpGet]
        [Route("/estimates/price")]
        public IActionResult GetPriceEstimates([FromQuery][Required()]double? startLatitude, [FromQuery][Required()]double? startLongitude, [FromQuery][Required()]double? endLatitude, [FromQuery][Required()]double? endLongitude)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/estimates/time")]
        public IActionResult GetTimeEstimates([FromQuery][Required()]double? startLatitude, [FromQuery][Required()]double? startLongitude, [FromQuery]string productId)
        {
            throw new NotImplementedException();
        }
    }
}
