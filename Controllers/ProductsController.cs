using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace UberAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
 
        [HttpGet]
        [Route("products")]
        public IActionResult GetProducts([FromQuery][Required()]double? latitude, [FromQuery][Required()]double? longitude)
        { 
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/products/{product_id}")]
        public virtual IActionResult GetProduct([FromRoute][Required]string productId)
        {
            throw new NotImplementedException();
        }
    }
}
