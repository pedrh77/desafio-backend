using AutoMapper;
using core_api.Features.Products.Contracts;
using core_api.Features.Products.DTO.Request;
using core_api.Features.Products.DTO.Response;
using core_api.Features.Products.Models;

namespace core_api.Features.Products.Services;

public class ProductService(IMapper _mapper, IProductRepo _repo) : IProductService
{
    public async Task NovoProdutoAsync(NovoProdutoRequest request)
    {
        await _repo.AddProductAsync(_mapper.Map<Product>(request));
        await _repo.Commit();
    }

    public async Task<IList<ProductsResponse>> BuscaProdutoAsync()
    {
       return _mapper.Map<IList<ProductsResponse>>(await _repo.ListProductsAsync());
    }
}
