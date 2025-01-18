namespace RiskOfRain.Web.ViewsModels;


public class MonstreViewModel
{
    public string? NomMonstre { get; set; }
    public int HpMonstre { get; set; }
    public string ImageUrl { get; set; }
    public MonstreViewModel(int hp, string nom, string imageUrl)
    {
        ImageUrl = imageUrl;
        NomMonstre = nom;
        HpMonstre = hp;
    }
}