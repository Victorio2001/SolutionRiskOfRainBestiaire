using RiskOfRain.Model;

namespace RiskOfRain.Web.ViewsModels;


public class MonstreViewModel
{
    public int IdMonstre { get; set; }
    public string NomMonstre { get; set; }
    public int PointCombatMonstre { get; set; }
    public string CouleurMonstre { get; set; }
    public int PvMonstre { get; set; }
    public int PvMaxMonstre { get; set; }
    public string TypeMonstre { get; set; }
    
    public static MonstreViewModel FromMonsterModel(Monstre model)
    {
        return new MonstreViewModel
        {
            IdMonstre = model.IdMonstre,
            CouleurMonstre = model.CouleurMonstre,
            NomMonstre = model.NomMonstre,
            PvMonstre = model.PvMonstre,
            PvMaxMonstre = model.PvMaxMonstre,
            PointCombatMonstre = model.PointCombatMonstre,
            TypeMonstre = model.TypeMonstre,
        };
    }
    
    public Model.Monstre ToEventModel()
    {
        Model.Monstre model = new Model.Monstre();

        model.IdMonstre = this.IdMonstre;
        model.NomMonstre = this.NomMonstre;
        model.CouleurMonstre = this.CouleurMonstre;
        model.PvMonstre = this.PvMonstre;
        model.PvMaxMonstre = this.PvMaxMonstre;
        model.PointCombatMonstre = this.PointCombatMonstre;
        model.TypeMonstre = this.TypeMonstre;
        
        return model;
    }

}