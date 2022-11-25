using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using UberAPI.Model;

namespace UberAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class EstimateController : ControllerBase
    {
        [HttpGet]
        [Route("/uber/api/estimates/price")]
        public Task<IActionResult> GetEstimatesPrice([FromQuery(Name = "startLocation")][Required()] Location startLocation, [FromQuery(Name = "endLocation")][Required()] Location endLocation)

        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/uber/api/estimates/time")]
        public Task<IActionResult> GetEstimatesTime([FromQuery(Name = "startLocation")][Required()] Location startLocation, [FromQuery(Name = "product_id")][Required()] Guid productId)

        {
            throw new NotImplementedException();
        }

    }
}
