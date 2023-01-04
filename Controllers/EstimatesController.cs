using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using UberAPI.Interface;
using UberAPI.Models;

namespace UberAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EstimatesController : ControllerBase
    { 
        private readonly IEstimateRepository _estimateRepository;
        private readonly ILogger<EstimatesController> _logger;

        public EstimatesController(IEstimateRepository estimateRepository, ILogger<EstimatesController> logger)
        {
            _estimateRepository = estimateRepository;
            _logger = logger;
        }

        [HttpGet]
        [Route("/estimates/price")]
        public IActionResult GetPriceEstimates([FromQuery][Required()]double? startLatitude, [FromQuery][Required()]double? startLongitude, [FromQuery][Required()]double? endLatitude, [FromQuery][Required()]double? endLongitude)
        {
            var startLocation = new LatLng() { Lat = startLatitude, Lng = startLongitude };
            var endLocation = new LatLng() {Lat = startLatitude, Lng = startLongitude };

            return new OkObjectResult(_estimateRepository.GetPriceEstimates(startLocation, endLocation));
        }

        [HttpGet]
        [Route("/estimates/time")]
        public IActionResult GetTimeEstimates([FromQuery][Required()]double? startLatitude, [FromQuery][Required()]double? startLongitude, [FromQuery]string productId)
        {
            var startLocation = new LatLng() { Lat = startLatitude, Lng = startLongitude };
            var endLocation = new LatLng() { Lat = startLatitude, Lng = startLongitude };

            return new OkObjectResult(_estimateRepository.GetTimeEstimates(startLocation, endLocation));
        }
    }
}
