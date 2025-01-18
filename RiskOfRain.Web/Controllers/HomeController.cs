using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RiskOfRain.Web.Models;
using RiskOfRain.Web.ViewsModels;

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
        //! utilisation de nôtre objet Monstre
        var MonstreList = new List<MonstreViewModel>();
        //! Ajout dans la list "Monstre" d'objet Monstre
        MonstreList.Add(new MonstreViewModel(100, "Alloy Vulture", "http://static.wikia.nocookie.net/riskofrain2_gamepedia_en/images/c/c4/Alloy_Vulture_-_Logbook_Model.jpg/revision/latest?cb=20200909171033"));
        MonstreList.Add(new MonstreViewModel(140, " Alpha Construct", "https://steamuserimages-a.akamaihd.net/ugc/1862807714340081871/3F64947FBEF6A107335F723A471C97D92484428A/"));
        
        //? un View Bag c'est genre un gros sac / un fourtout c'est vraiment pas très propre d'utiliser ceci
        //ViewBag.Title = "Bestiaire RiskOfRain";
        //ViewBag.Monstre = MonstreList;
        
        MonstreIndexViewModel viewmodel = new MonstreIndexViewModel();
        viewmodel.Monstres = MonstreList;
        viewmodel.pageTitle = "Monstres pages";
   
        return View(viewmodel);
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