using Microsoft.EntityFrameworkCore;
using RiskOfRain.DataContext;
using RiskOfRain.DataSource.interfaces;
using RiskOfRain.Model;

namespace RiskOfRain.DataSource.repository;

public class MonstreRepository : IMonstreRepository
{

    private readonly RiskOfRainContext context;
    
    public MonstreRepository( RiskOfRainContext context )
    {
        this.context = context;
    }

    public async Task<IEnumerable<Monstre>> GetMonstre()
    {
        return await context.Monstres.ToListAsync();
    }

    public async Task<Monstre> GetMonstreByIdAsync(int? id)
    {
        return await context.Monstres.FindAsync(id);
    }


}