using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using UberAPI.Interface;
using UberAPI.Models;

namespace UberAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productsRepository;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(IProductRepository productsRepository, ILogger<ProductsController> logger)
        {
            _productsRepository = productsRepository;
            _logger = logger;
        }

        [HttpGet]
        [Route("products")]
        public IActionResult GetProducts([FromQuery][Required()]double? latitude, [FromQuery][Required()]double? longitude)
        {
            _logger.LogInformation("[UberAPI:ProductsController:GetProducts] Controller endpoint invoked..");
            _logger.LogInformation($"[UberAPI:ProductsController:GetProducts] Data Received: Start Long & Lat: {longitude}-{latitude}");

            var location = new LatLng() { Lat = latitude, Lng = longitude };

            return new OkObjectResult(_productsRepository.GetProducts(location));
        }

        [HttpGet]
        [Route("/products/{productId}")]
        public IActionResult GetProduct([FromRoute] string? productId)
        {
            _logger.LogInformation("[UberAPI:ProductsController:GetProduct] Controller endpoint invoked..");
            _logger.LogInformation($"[UberAPI:ProductsController:GetProduct] Data Received: Product ID: {productId}");
            if (productId is null) return BadRequest("Error: Invalid data receieved (null)");

            return new OkObjectResult(_productsRepository.GetProduct(productId));
        }
    }
}
