using core_api.Features.Histories.Contracts;
using core_api.Features.Histories.Repos;
using core_api.Features.Histories.Services;

namespace core_api.Features.Histories.IoC
{
    public static class HistoryDI
    {
        public static IServiceCollection AddHistoryInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IHistoryRepo, HistoryRepo>();
            services.AddScoped<IHistoryServices, HistoryServices>();
            return services;
        }
    }
}
