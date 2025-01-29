using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RiskOfRain.DataSource.interfaces;
using RiskOfRain.Model;
using RiskOfRain.Web.Models;
using RiskOfRain.Web.ViewsModels;

namespace RiskOfRain.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IMonstreRepository _monstreRepository;

    public HomeController(ILogger<HomeController> logger, IMonstreRepository monstreRepository)
    {
        _logger = logger;
        _monstreRepository = monstreRepository;
    }
    
    [HttpGet]
    public async Task<IActionResult>Index()
    {
        var monstre = await _monstreRepository.GetMonstre();
        
        List<MonstreViewModel> res = monstre.Select(MonstreViewModel.FromMonsterModel).ToList();

        
        MonstreIndexViewModel viewmodel = new MonstreIndexViewModel();
        
        viewmodel.Monstres = res;
        viewmodel.pageTitle = "Monstres pages";
   
        return View(viewmodel);
    }
    
    [HttpGet("Home/Create")]
    public async Task<IActionResult>Create()
    {
        var vm = new MonstreCreateViewModel();
        vm.pageTitle = "Create Monstre";
        vm.Monstres = new MonstreViewModel();
        
        return View(vm);
    }
    
    
    [HttpPost("Home/Create")]
    public async Task<IActionResult>CreateMonster( MonstreCreateViewModel model)
    {
        Monstre eventModel = model.Monstres.ToEventModel();
        await _monstreRepository.AddMonMOnstre(eventModel);
        
        return RedirectToAction("Index");
    }
    
    [HttpGet("Home/Edit/{id}")]
    public async Task<IActionResult>Edit(int id)
    {
        var req = await _monstreRepository.GetMonstreByIdAsync(id);
        MonstreEditViewModel vm = new MonstreEditViewModel();
        
        vm.Monstres = MonstreViewModel.FromMonsterModel(req);
        vm.pageTitle = "Edit Monstre";
        
        
        return View(vm);
    }
    
    
    [HttpPost]
    public async Task<IActionResult>EditMonster(MonstreEditViewModel model)
    {
        Monstre eventModel = model.Monstres.ToEventModel();
        await _monstreRepository.EditMonMOnstre(eventModel);
        
        return RedirectToAction("Index");
    }
    
    
    [HttpGet("Home/Delete/{id}")]
    public async Task<IActionResult>DeleteMonster(int id)
    {
    
        await _monstreRepository.DeleteMonMOnstre(id);
        return RedirectToAction("Index");
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