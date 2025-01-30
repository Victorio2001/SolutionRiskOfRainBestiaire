using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RiskOfRain.DataContext.EntityTypesConfiguration;
using RiskOfRain.DataContext.SeedData;
using RiskOfRain.Model;
using RiskOfRain.Model.Identity;


namespace RiskOfRain.DataContext
{
    public class RiskOfRainContext : IdentityDbContext<User>
    {
        protected RiskOfRainContext()
        {
        }
        public RiskOfRainContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            //!Conf Entity Ici
            modelBuilder.ApplyConfiguration(new MonstreEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AttaqueMonstreEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AttaqueEntityTypeConfiguration());
            //!Conf Entity Ici

            //! mettre ici les seeedata
            SeedDataMonstre.SeedDatabase(modelBuilder);
            SeedDataAttaque.SeedDatabase(modelBuilder);
            SeedDataAttaqueMonstre.SeedDatabase(modelBuilder);
            //! mettre ici les seeedata
        }
        //! Déclaration des tables
        public DbSet<Monstre> Monstres { get; set; }
        public DbSet<Attaque> Attaques { get; set; }
        public DbSet<AttaqueMonstre> AttaqueMonstre { get; set; }
        //! Déclaration des tables
    }
}