using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiskOfRain.Model;

namespace RiskOfRain.DataContext.EntityTypesConfiguration
{
    public class MonstreEntityTypeConfiguration : IEntityTypeConfiguration<Monstre>
    {
        public void Configure(EntityTypeBuilder<Monstre> builder)
        {
            //! Pk
            builder.HasKey(e => e.IdMonstre);
            
            //! FK
            builder.HasMany(e => e.AttaqueMonstre)
                .WithOne(r => r.Monstre)
                .HasForeignKey(r => r.IdMonstre)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}