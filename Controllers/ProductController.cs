using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using UberAPI.Model;

namespace UberAPI.Controllers
{
    // [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("/uber/api/products")]
        [Consumes("application/json")]
        public Task<IActionResult> GetProducts([FromQuery(Name = "productLocation"), Required] Location productLocation)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/uber/api/products/{product_id}")]
        [Consumes("application/json")]
        public Task<IActionResult> GetProductId([FromRoute (Name = "product_id")][Required]Guid productId)
        {
            throw new NotImplementedException();
        }
    }
}
