using RiskOfRain.Model;
using Microsoft.EntityFrameworkCore;

namespace RiskOfRain.DataContext.SeedData;

public static class SeedDataAttaqueMonstre
{
    public static void SeedDatabase(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<AttaqueMonstre>()

        .HasData(
            new AttaqueMonstre()
            {   
                IdAttaqueMonstre = 1,
                IdAttaque = 1,
                IdMonstre = 1,
            },
            new AttaqueMonstre()
            {
                IdAttaqueMonstre = 2,
                IdAttaque = 2,
                IdMonstre = 1,
            }
           
        );
}
}