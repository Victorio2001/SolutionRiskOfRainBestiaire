using RiskOfRain.Model;

namespace RiskOfRain.DataSource.interfaces;

public interface IMonstreRepository
{
    Task<IEnumerable<Monstre>> GetMonstre();

    Task<Monstre> GetMonstreByIdAsync(int? id);
    
}