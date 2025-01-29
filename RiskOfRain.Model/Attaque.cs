namespace RiskOfRain.Model;

public class Attaque
{
    public int IdAttaque { get; set; }
    public string NomAttaque { get; set; }
    public int Physique { get; set; }
    public int Magie { get; set; }
    public int CoutPointCombat { get; set; }
    public ICollection<AttaqueMonstre> AttaqueMonstre { get; set; }
}