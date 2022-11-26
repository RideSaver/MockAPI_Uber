using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using UberAPI.Interface;
using UberAPI.Models;

namespace UberAPI.Controllers
{
    [ApiController]
    public class EstimateController : ControllerBase
    {
        private readonly IEstimateRepository _estimateRepository;
        public EstimateController(IEstimateRepository estimateRepository) => _estimateRepository = estimateRepository;

        [HttpGet]
        [Route("/uber/api/estimates/price")]
        public Task<IActionResult> GetEstimatesPrice([FromQuery(Name = "startLocation")][Required()]Location startLocation, [FromQuery(Name = "endLocation")][Required()]Location endLocation)

        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/uber/api/estimates/time")]
        public Task<IActionResult> GetEstimatesTime([FromQuery(Name = "startLocation")][Required()]Location startLocation, [FromQuery(Name = "product_id")][Required()]string productId)

        {
            throw new NotImplementedException();
        }

    }
}
