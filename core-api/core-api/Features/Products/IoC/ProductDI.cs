using core_api.Features.Products.Contracts;
using core_api.Features.Products.Repos;
using core_api.Features.Products.Services;

namespace core_api.Features.Products.IoC;

public static class ProductDI
{
    public static IServiceCollection AddProductInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IProductRepo, ProductRepo>();
        services.AddScoped<IProductService, ProductService>();
        return services;
    }

}
