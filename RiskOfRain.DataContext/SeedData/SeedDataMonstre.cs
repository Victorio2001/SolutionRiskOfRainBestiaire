using RiskOfRain.Model;
using Microsoft.EntityFrameworkCore;

namespace RiskOfRain.DataContext.SeedData;

public static class SeedDataMonstre
{
    public static void SeedDatabase(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Monstre>()

        .HasData(
            new Monstre()
            {
                IdMonstre = 1,
                NomMonstre = "Alpha Construct",
                PointCombatMonstre = 55,
                CouleurMonstre = "Rouge",
                PvMonstre = 100,
                PvMaxMonstre = 125,
                TypeMonstre = "Mutant",
            },
            new Monstre()
            {
                IdMonstre = 2,
                NomMonstre = "Alloy Vulture",
                PointCombatMonstre = 120,
                CouleurMonstre = "Bleu",
                PvMonstre = 180,
                PvMaxMonstre = 180,
                TypeMonstre = "Mage",
            }
           
        );
}
}