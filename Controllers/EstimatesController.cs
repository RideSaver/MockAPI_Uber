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
            _logger.LogInformation("[UberAPI:EstimatesController:GetPriceEstimates] Controller endpoint invoked..");
            _logger.LogInformation($"[UberAPI:EstimatesController:GetPriceEstimates] Data Received: Start Long & Lat: {startLongitude}-{startLatitude}");
            _logger.LogInformation($"[UberAPI:EstimatesController:GetPriceEstimates] Data Received: End Long & Lat: {endLongitude}-{endLatitude}");

            var startLocation = new LatLng() { Lat = startLatitude, Lng = startLongitude };
            var endLocation = new LatLng() {Lat = startLatitude, Lng = startLongitude };

            return new OkObjectResult(_estimateRepository.GetPriceEstimates(startLocation, endLocation));
        }

        [HttpGet]
        [Route("/estimates/time")]
        public IActionResult GetTimeEstimates([FromQuery][Required()]double? startLatitude, [FromQuery][Required()]double? startLongitude, [FromQuery]string productId)
        {
            _logger.LogInformation("[UberAPI:EstimatesController:GetTimeEstimates] Controller endpoint invoked..");
            _logger.LogInformation($"[UberAPI:EstimatesController:GetTimeEstimates] Data Received: Start Long & Lat: {startLongitude}-{startLatitude}");
            _logger.LogInformation($"[UberAPI:EstimatesController:GetTimeEstimates] Data Received: Product ID : {productId}");


            var startLocation = new LatLng() { Lat = startLatitude, Lng = startLongitude };
            var endLocation = new LatLng() { Lat = startLatitude, Lng = startLongitude };

            return new OkObjectResult(_estimateRepository.GetTimeEstimates(startLocation, endLocation));
        }
    }
}
