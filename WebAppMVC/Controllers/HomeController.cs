using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using webAppMVC.Models;

namespace webAppMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    

    List<Student> studentlist;


    [Route("")]
    [Route("Home/Index")]
    public IActionResult Index()
    {
        // ViewData["uName"]="Shenba"; 
        // TempData["dept"]="Software";
        // ViewBag.Email="Bu@gmail.com";
        studentlist=new List<Student>(){
            new Student(){StudentId=101,StudentName="Shenba",DepartmentId="1001",Gender="Male",EmailId="shenbaemail"},
            new Student(){StudentId=102,StudentName="Bala",DepartmentId="1002",Gender="Male",EmailId="balaaemail"},
            new Student(){StudentId=103,StudentName="Bhu",DepartmentId="1001",Gender="Male",EmailId="bhuemail"},
            new Student(){StudentId=104,StudentName="Buvan",DepartmentId="1002",Gender="Male",EmailId="buvanemail"},
            new Student(){StudentId=105,StudentName="Ram",DepartmentId="1001",Gender="Male",EmailId="ramemail"}
        };

        return View(studentlist);
    }
    // public String Index(string id, string name)
    // {
    //     return "hello "+id+ " name "+name;
    // }
    [Route("Home/Privacy")]
    public IActionResult Privacy()
    {
        return View();
    }
    [Route("Home/hello")]
    public IActionResult hello()
    {
        return View();
    }
    [Route("Home/Show")]
    public IActionResult Show(){
        // ViewBag.emp = new Employee();

        // return View(new Employee());

        // Employee emp=new Employee(){
        //     EmpId=102,
        //     EmpName="ssss",
        //     ProjectId=901
        // };
        // Project pro=new Project(){
        //     ProjectId=901,
        //     ProjectName="OneCore",
        //     ProjectDes="Child care"
        // };
        // EmpProjectDetails emppro = new EmpProjectDetails(){
        //     empobj=emp,
        //     proobj=pro
        // };
        // return View(emppro);
        return View();
    }
    [Route("Home/welcome")]
    public IActionResult welcome()
    {
        List<string> empName=new List<string>();
        empName.Add("Sheba");
        empName.Add("Bala");
        empName.Add("Bhu");
        ViewData["Names"]=empName;
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
