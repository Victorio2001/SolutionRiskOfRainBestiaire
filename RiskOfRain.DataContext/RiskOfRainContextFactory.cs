using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace RiskOfRain.DataContext
{
    public class RiskOfRainContextFactory : IDesignTimeDbContextFactory<RiskOfRainContext>
    {
        public RiskOfRainContext CreateDbContext(string[] args)
        {
            //! Récupération de la configuration 
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var configuration = configurationBuilder.Build();

            
            //! Création du contexte en lui passabt la configuration
            DbContextOptionsBuilder<RiskOfRainContext> builder = new DbContextOptionsBuilder<RiskOfRainContext>();
            
            
            //! Récupération de la chaine de configuration dans le fichier de configuration
            builder.UseSqlServer(configuration.GetConnectionString("RiskOfRainContext"));
            
            return new RiskOfRainContext(builder.Options);
        }
    }


}