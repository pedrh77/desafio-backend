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

        var connectionString = $"server={dbHost};port={dbPort};userid={dbUser};pwd={dbPassword};database={dbDatabase};default command timeout=0;";

        services.AddDbContext<DataContext>(options => { options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)); });

        return services;
    }

    public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
    {
        app.UseExceptionHandler();
        return app;
    }
}