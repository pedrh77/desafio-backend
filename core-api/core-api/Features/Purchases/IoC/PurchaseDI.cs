using core_api.Features.Purchases.Contracts;
using core_api.Features.Purchases.Repos;
using core_api.Features.Purchases.Services;

namespace core_api.Features.Purchases.IoC
{
    public static class PurchaseDI
    {
        public static IServiceCollection AddPurchaseInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IPurchaseRepo, PurchaseRepo>();
            services.AddScoped<IPurchaseServices, PurchaseServices>();
            return services;
        }
    }
}
