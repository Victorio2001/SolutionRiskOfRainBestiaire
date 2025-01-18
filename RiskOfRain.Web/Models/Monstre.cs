namespace RiskOfRain.Web.Models;

public class Monstre
{
    public string? NomMonstre { get; set; }
    public int HpMonstre { get; set; }
    public string ImageUrl { get; set; }
    public Monstre(int hp, string nom, string imageUrl)
    {
        ImageUrl = imageUrl;
        NomMonstre = nom;
        HpMonstre = hp;
    }
}