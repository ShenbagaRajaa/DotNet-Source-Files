using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TypeWrittingBack.Models;

namespace TypeWrittingBack;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly UserDetailsContext EmployeeContext;
    public EmployeeController(UserDetailsContext context)
    {
        EmployeeContext = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<EmployeesDetailsShenba>>> GetAllEmployeeDetials()
    {
        return await EmployeeContext.EmployeesDetailsShenba.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<EmployeesDetailsShenba>> GetParticularEmployee(int id)
    {
        return await EmployeeContext.EmployeesDetailsShenba.FindAsync(id);
    }

    

    [HttpDelete("{id}")]
    public async Task<ActionResult<IEnumerable<EmployeesDetailsShenba>>> DeleteEmployee(int id)
    {
        var Employeedata = await EmployeeContext.EmployeesDetailsShenba.FindAsync(id);
        if (Employeedata == null)
        {
            return NotFound();
        }
        EmployeeContext.EmployeesDetailsShenba.Remove(Employeedata);
        await EmployeeContext.SaveChangesAsync();
        return Ok("Deleteed Successfully");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateEmployee(int id, EmployeesDetailsShenba Employee)
    {
        if (id != Employee.EmployeeId)
        {
            return BadRequest("Id Not matched");
        }

        EmployeeContext.Entry(Employee).State = EntityState.Modified;

        try
        {
            await EmployeeContext.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!EmployeeExists(id))
            {
                return NotFound("Employee doesn't exist");
            }
            else
            {
                throw;
            }
        }
        return Ok("Updated Successfully");
    }
   

    [HttpPost]
    public async Task<IActionResult> AddEmployee(frontendEmployee Employee)
    {
        byte[] passalt = PasswordHasher.GenerateSalt();
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var existingUser = await EmployeeContext.EmployeesDetailsShenba.FirstOrDefaultAsync(u => u.UserName == Employee.UserName);

        if (existingUser != null)
        {
            return BadRequest("Username already exists");
        }

        var user1 = new EmployeesDetailsShenba
        {
            UserName = Employee.UserName,
            EmployeeName = Employee.EmployeeName,
            Email = Employee.Email,
            PhoneNo = Employee.PhoneNo,
            Designation = Employee.Designation,
            PasswordSalt = Convert.ToBase64String(passalt),
            PasswordHash = PasswordHasher.ComputeHash(Employee.Password, passalt)
        };
 
        EmployeeContext.EmployeesDetailsShenba.Add(user1);
        await EmployeeContext.SaveChangesAsync();
        // return CreatedAtAction("GetParticularStudent", new { id = user1.EmployeeId }, user1);
        return Ok("Added Successfully");
    }

   private  bool EmployeeExists(int id)
    {
        return EmployeeContext.EmployeesDetailsShenba.Any(e => e.EmployeeId == id);
    }
}
