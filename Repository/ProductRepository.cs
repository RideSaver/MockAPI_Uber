using UberAPI.Interface;
using UberAPI.Models;
using UberAPI.Registry;

namespace UberAPI.Repository

{
    public class ProductRepository : IProductRepository
    {
        public Product GetProduct(string productId)
        {
            var product = ProductGenerator.GenerateProduct();
            product.ProductId = productId;
            return product;
        }

        public ProductList GetProducts(LatLng location)
        {
            var productList = ProductGenerator.GenerateProducts(10);
            return productList;
        }
    }
}
