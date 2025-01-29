using RiskOfRain.Model;
using Microsoft.EntityFrameworkCore;

namespace RiskOfRain.DataContext.SeedData;

public static class SeedDataAttaque
{
    public static void SeedDatabase(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Attaque>()

        .HasData(
            new Attaque()
            {
                IdAttaque = 1,
                NomAttaque = "Charge",
                Physique = 40,
                Magie = 0,
                CoutPointCombat = 5,
            },
            new Attaque()
            {
                IdAttaque = 2,
                NomAttaque = "FireBall",
                Physique = 0,
                Magie = 65,
                CoutPointCombat = 15,
            },
            new Attaque()
            {
                IdAttaque = 3,
                NomAttaque = "FirePunch",
                Physique = 60,
                Magie = 0,
                CoutPointCombat = 10,
            }
           
        );
}
}