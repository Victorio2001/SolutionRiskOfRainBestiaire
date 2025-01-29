namespace RiskOfRain.Model;

public class AttaqueMonstre
{
    public int IdAttaqueMonstre { get; set; }
    public int IdMonstre { get; set; }
    public int IdAttaque { get; set; }
    public Attaque Attaque { get; set; }
    public Monstre Monstre { get; set; }
}