using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RiskOfRain.Web.Models;

namespace RiskOfRain.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    public IActionResult Index()
    {
        //! Option numéro un pour passer de laaa data à ta page -- ps: c'est null de faire sa
        var Monstre = new List<Monstre>();
        Monstre.Add(new Monstre(100, "Alloy Vulture", "http://static.wikia.nocookie.net/riskofrain2_gamepedia_en/images/c/c4/Alloy_Vulture_-_Logbook_Model.jpg/revision/latest?cb=20200909171033"));
        Monstre.Add(new Monstre(140, " Alpha Construct", "https://steamuserimages-a.akamaihd.net/ugc/1862807714340081871/3F64947FBEF6A107335F723A471C97D92484428A/"));
        ViewBag.Title = "Bestiaire RiskOfRain";
        ViewBag.Monstre = Monstre;
   
        return View(Monstre);
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}