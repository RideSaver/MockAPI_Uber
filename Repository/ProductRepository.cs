using UberAPI.Interface;
using UberAPI.Models;

namespace UberAPI.Repository

{
    public class ProductRepository : IProductRepository
    {
        public Product GetProduct(string productId)
        {
            throw new NotImplementedException();
        }

        public ProductList GetProducts(LatLng location)
        {
            throw new NotImplementedException();
        }
    }
}
