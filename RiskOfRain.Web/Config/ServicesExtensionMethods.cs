using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RiskOfRain.DataContext;
using RiskOfRain.DataSource.interfaces;
using RiskOfRain.DataSource.repository;
using RiskOfRain.Model.Identity;

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
        
        
        services.AddIdentityCore<User>()
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<RiskOfRainContext>()
            .AddSignInManager()
            .AddDefaultTokenProviders();

        services.AddAuthentication(e =>
        {
            e.DefaultScheme = IdentityConstants.ApplicationScheme;
            e.DefaultSignInScheme = IdentityConstants.ExternalScheme;
        }).AddIdentityCookies(e => { });
            
        
        
        
            
        return services;
    }
    
}