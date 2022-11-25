using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using UberAPI.Model;

namespace UberAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("/uber/api/products")]
        [Consumes("application/json")]
        public Task<IActionResult> GetProducts([FromQuery(Name = "latitude"), Required] float locationLat, [FromQuery(Name = "longitude"), Required] float locationLong)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/uber/api/products/{product_id}")]
        [Consumes("application/json")]
        public async Task<IActionResult> GetProductId([FromRoute (Name = "product_id")][Required]string product_id)
        {
            throw new NotImplementedException();
        }
    }
}
