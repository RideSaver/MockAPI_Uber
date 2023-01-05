using UberAPI.Interface;
using UberAPI.Models;
using UberAPI.Registry;

namespace UberAPI.Repository

{
    public class ProductRepository : IProductRepository
    {
        public ProductList GetProducts(LatLng location) => ProductGenerator.GenerateProducts(10);
        public Product GetProduct(string productId)
        {
            var product = ProductGenerator.GenerateProduct();
            product.ProductId = productId;
            return product;
        }
    }
}
