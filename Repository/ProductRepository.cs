using UberAPI.Interface;
using UberAPI.Models;
using UberAPI.Registry;

namespace UberAPI.Repository

{
    public class ProductRepository : IProductRepository
    {
        public ProductList GetProducts(LatLng location) => ProductGenerator.GenerateProducts(10);
        public async Task<Product> GetProduct(string productId)
        {
            var product = await Task.FromResult(ProductGenerator.GenerateProduct());
            product.ProductId = productId;
            return product;
        }
    }
}
