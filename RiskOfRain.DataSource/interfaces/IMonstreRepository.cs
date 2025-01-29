using RiskOfRain.Model;

namespace RiskOfRain.DataSource.interfaces;

public interface IMonstreRepository
{
    Task<IEnumerable<Monstre>> GetMonstre();

    Task<Monstre> GetMonstreByIdAsync(int? id);

    Task AddMonMOnstre(Monstre monstre);

    Task EditMonMOnstre(Monstre monstre);

    Task DeleteMonMOnstre(int id);

}