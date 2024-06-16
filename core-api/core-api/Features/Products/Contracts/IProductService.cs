using core_api.Features.Products.DTO.Request;
using core_api.Features.Products.DTO.Response;

namespace core_api.Features.Products.Contracts
{
    public interface IProductService
    {
        Task<IList<ProductsResponse>> BuscaProdutoAsync();
        Task NovoProdutoAsync(NovoProdutoRequest request);
    }
}
