using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace AssessmentMVC;

// [Route("Employee")]
public class EmployeeController:Controller
{
    private readonly EmployeeContext? EmpContext;
    public EmployeeController(EmployeeContext context)
    {
        EmpContext = context;
    }
    // [Route("Employee/Index")]
    public async Task<IActionResult> Index()
    {
        return View(await EmpContext.EmployeeAsShenba.ToListAsync());
    }
}
