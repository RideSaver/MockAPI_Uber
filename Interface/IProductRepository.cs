using UberAPI.Models;

namespace UberAPI.Interface
{
    public interface IProductRepository
    {
        ProductList GetProducts(LatLng location);
        Task<Product> GetProduct(string productId);
    }
}
