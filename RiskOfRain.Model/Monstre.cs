namespace RiskOfRain.Model;

public class Monstre
{
    public int IdMonstre { get; set; }
    public string NomMonstre { get; set; }
    public int PointCombatMonstre { get; set; }
    public string CouleurMonstre { get; set; }
    public int PvMonstre { get; set; }
    public int PvMaxMonstre { get; set; }
    public string TypeMonstre { get; set; }
    public ICollection<AttaqueMonstre> AttaqueMonstre { get; set; }
}