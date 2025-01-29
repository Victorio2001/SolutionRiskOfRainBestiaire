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
        return await context.Monstres
            .FirstOrDefaultAsync(e => e.IdMonstre == id);
    }
    
    public async Task AddMonMOnstre(Monstre monstre)
    { 
        await context.Monstres.AddAsync(monstre);
        await context.SaveChangesAsync();
    }
    
    public async Task EditMonMOnstre(Monstre monstre)
    { 
        context.Monstres.Update(monstre);
        await context.SaveChangesAsync();
    }
    
    public async Task DeleteMonMOnstre(int id)
    { 
        
        var Res = await context.Monstres.FindAsync(id);
        
        context.Monstres.Remove(Res);
        await context.SaveChangesAsync();
    }



}