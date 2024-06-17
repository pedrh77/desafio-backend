using core_api.Features.Histories.IoC;
using core_api.Features.Products.IoC;
using core_api.Features.Purchases.IoC;
using core_api.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace core_api.Infra.IoC;


public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        var dbHost = config["DB_HOST"];
        var dbPort = config["DB_PORT"];
        var dbDatabase = config["DB_DATABASE"];
        var dbUser = config["DB_USER"];
        var dbPassword = config["DB_PWD"];

        var connectionString = $"Server={dbHost};Port={dbPort};Database={dbDatabase};User Id={dbUser};Password={dbPassword};";

        services.AddDbContext<DataContext>(opt => opt.UseNpgsql(connectionString));

        services.AddProductInfrastructure().AddPurchaseInfrastructure().AddHistoryInfrastructure();
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        return services;
    }

    public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
    {
        app.UseExceptionHandler();
        return app;
    }
}