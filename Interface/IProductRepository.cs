using UberAPI.Models;

namespace UberAPI.Interface
{
    public interface IProductRepository
    {
        ProductList GetProducts(LatLng location);
        Product GetProduct(string productId);
    }
}
