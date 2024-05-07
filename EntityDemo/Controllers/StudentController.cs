using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EntityDemo;

public class StudentController : Controller
{
    private readonly CollegeContext? myCollegeContext;
    public StudentController(CollegeContext context)
    {
        myCollegeContext = context;
    }
    public async Task<IActionResult> Index()
    {
        return View(await myCollegeContext.StudentShenbaORM.ToListAsync());
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create([Bind("StudentId,StudentName,DepartmentId,Gender")] StudentShenbaORM student)
    {
        if (ModelState.IsValid)
        {
            myCollegeContext.Add(student);
            await myCollegeContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(student);
    }
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
 
        var student = await myCollegeContext.StudentShenbaORM
            .FirstOrDefaultAsync(m => m.StudentId == id);
        if (student == null)
        {
            return NotFound();
        }

        return View(student);
    }
}
