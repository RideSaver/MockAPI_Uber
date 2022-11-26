using UberAPI.Models;

namespace UberAPI.Interface
{
    public interface IProductRepository
    {
        List<Product> GetAvailableProducts(Location location);
        List<Product> GetProducts(string productId);

    }
}
