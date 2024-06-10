using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    // public HomeController(ILogger<HomeController> logger)
    // {
    //     _logger = logger;
    // }

 List<Student> studentlist;

    public HomeController(){
        studentlist=new List<Student>(){
            new Student(){StudentId=101,StudentName="Shenba",DepartmentId="1001",Gender="Male",EmailId="shenbaemail"},
            new Student(){StudentId=102,StudentName="Bala",DepartmentId="1002",Gender="Male",EmailId="balaaemail"},
            new Student(){StudentId=103,StudentName="Bhu",DepartmentId="1001",Gender="Male",EmailId="bhuemail"},
            new Student(){StudentId=104,StudentName="Buvan",DepartmentId="1002",Gender="Male",EmailId="buvanemail"},
            new Student(){StudentId=105,StudentName="Ram",DepartmentId="1001",Gender="Male",EmailId="ramemail"}
        };
    }
    public IActionResult Index()
    {
        return View(studentlist);
    }
    public IActionResult Studentdetails(int id){
        var studentData=studentlist.FirstOrDefault(std=>std.StudentId==id);
        return View(studentData);
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
