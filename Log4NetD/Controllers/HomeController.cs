using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Log4NetD.Models;

namespace Log4NetD.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _logger.LogDebug("Debug Msg");
        _logger.LogInformation("Info msg");
        _logger.LogError("Error msg");
        _logger.LogWarning("Warn msg");
    }

    public IActionResult Index()
    {
        return View();
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
