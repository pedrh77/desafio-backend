using core_api.Features.Products.Models;

namespace core_api.Features.Products.Contracts
{
    public interface IProductRepo
    {
        Task<IList<Product>> ListProductsAsync();
        Task<IList<Product>> ListProductsByIdAsync(int id);
        Task<Product> AddProductAsync(Product product);
        Task Commit();
    }
}
