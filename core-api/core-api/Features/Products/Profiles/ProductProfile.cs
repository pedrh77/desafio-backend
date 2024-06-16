using AutoMapper;
using core_api.Features.Products.DTO.Request;
using core_api.Features.Products.DTO.Response;
using core_api.Features.Products.Models;

namespace core_api.Features.Products.Profiles;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<NovoProdutoRequest, Product>();

        CreateMap<Product, ProductsResponse>();
    }
}
