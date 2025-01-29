using Microsoft.EntityFrameworkCore;


namespace RiskOfRain.DataContext
{
    public class RiskOfRainContext : DbContext
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
            //!Conf Entity Ici
            
            //! mettre ici les seeedata
            //! mettre ici les seeedata
            
        }
        //! Déclaration des tables
        //! Déclaration des tables
    }
}