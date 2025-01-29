using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiskOfRain.Model;

namespace RiskOfRain.DataContext.EntityTypesConfiguration
{
    public class AttaqueEntityTypeConfiguration : IEntityTypeConfiguration<Attaque>
    {
        public void Configure(EntityTypeBuilder<Attaque> builder)
        {
            //! Pk
            builder.HasKey(e => e.IdAttaque);
            
            //! FK
            builder.HasMany(e => e.AttaqueMonstre)
                .WithOne(r => r.Attaque)
                .HasForeignKey(r => r.IdAttaque)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}