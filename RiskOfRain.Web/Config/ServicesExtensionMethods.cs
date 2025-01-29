using Microsoft.EntityFrameworkCore;
using RiskOfRain.DataContext;
using RiskOfRain.DataSource.interfaces;
using RiskOfRain.DataSource.repository;

namespace RiskOfRain.Web.Config;

public static class ServicesExtensionMethods
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IMonstreRepository, MonstreRepository>();
        
        string connectionString = configuration.GetConnectionString("RiskOfRainContext");
        services.AddDbContext<RiskOfRainContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
            
        return services;
    }
    
}