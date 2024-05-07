using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aurtho.Models;
using Microsoft.AspNetCore.Authorization;

namespace Aurtho.Controllers;
[Authorize(Roles ="")]
public class HomeController : Controller
{
    [Authorize(Roles ="CTO,Project Manager, Employee")]
    public IActionResult Index()
    {
        return View();
    }
    [Authorize(Roles ="CTO")]
    public IActionResult Privacy()
    {
        return View();
    }
    [Authorize(Roles ="CTO,Project Manager")]
    public IActionResult AppSettingsz(){
        return View();
    }
}
