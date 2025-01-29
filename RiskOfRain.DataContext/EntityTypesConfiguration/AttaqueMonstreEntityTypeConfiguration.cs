using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiskOfRain.Model;

namespace RiskOfRain.DataContext.EntityTypesConfiguration
{
    public class AttaqueMonstreEntityTypeConfiguration : IEntityTypeConfiguration<AttaqueMonstre>
    {
        public void Configure(EntityTypeBuilder<AttaqueMonstre> builder)
        {
            //! Pk
            builder.HasKey(e => e.IdAttaqueMonstre);
            
            
            //! FK
            builder.HasOne(e => e.Attaque)
                .WithMany(e => e.AttaqueMonstre) 
                .HasForeignKey(e => e.IdAttaque) 
                .OnDelete(DeleteBehavior.Cascade); 

            builder.HasOne(e => e.Monstre) 
                .WithMany(e => e.AttaqueMonstre)
                .HasForeignKey(e => e.IdMonstre) 
                .OnDelete(DeleteBehavior.Cascade);
        
        }
    }
}