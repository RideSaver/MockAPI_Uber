using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using UberAPI.Interface;
using UberAPI.Models;

namespace UberAPI.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository) => _productRepository = productRepository;

        [HttpGet]
        [Route("/uber/api/products")]
        [Consumes("application/json")]
        public async Task<IActionResult> GetProductsAsync([FromQuery(Name = "productLocation"), Required]Location productLocation) 
        {
            await Task.Delay(100);
            return new OkObjectResult(_productRepository.GetAvailableProducts(productLocation));
        }

        [HttpGet]
        [Route("/uber/api/products/{product_id}")]
        [Consumes("application/json")]
        public async Task<IActionResult> GetProductAsync([FromRoute(Name = "product_id")][Required]string productId)
        {
            await Task.Delay(100);
            return new OkObjectResult(_productRepository.GetProducts(productId));
        }
    }
}
