using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TypeWrittingBack.Models;

namespace TypeWrittingBack;

[ApiController]
[Route("api/[controller]")]

public class StudentController:ControllerBase
{ 
    private readonly UserDetailsContext studentContext;
    public StudentController(UserDetailsContext context)
    {
        studentContext = context;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<IEnumerable<StudentsDetailsShenba>>> GetAllStudentDetials()
    {
        return await studentContext.StudentsDetailsShenba.ToListAsync();
    }

    [HttpGet("GetById/{id}")]
    public async Task<ActionResult<StudentsDetailsShenba>> GetParticularStudent(int id)
    {
        return await studentContext.StudentsDetailsShenba.FindAsync(id);
    }

    [HttpGet("maxId")]
    public async Task<IActionResult> GetMaxValue()
    {
        var maxId = await studentContext.StudentsDetailsShenba.MaxAsync(p => p.StudentId);
        return Ok(maxId);
    }

    [HttpPost("AddNewStudent")]
    public async Task<ActionResult<StudentsDetailsShenba>> AddStudent(StudentsDetailsShenba student)
    {
        studentContext.StudentsDetailsShenba.Add(student);
        await studentContext.SaveChangesAsync();
        return CreatedAtAction("GetParticularStudent", new { id = student.StudentId }, student);
    }

    [HttpDelete("DeleteById/{id}")]
    public async Task<ActionResult<IEnumerable<StudentsDetailsShenba>>> DeleteStudent(int id)
    {
        var studentdata = await studentContext.StudentsDetailsShenba.FindAsync(id);
        if (studentdata == null)
        {
            return NotFound();
        }
        studentContext.StudentsDetailsShenba.Remove(studentdata);
        await studentContext.SaveChangesAsync();
        return await studentContext.StudentsDetailsShenba.ToListAsync();
        // return NoContent();
    }

    [HttpPut("Update/{id}")]
    public async Task<IActionResult> UpdateStudent(int id, StudentsDetailsShenba student)
    {
        if (id != student.StudentId)
        {
            return BadRequest();
        }

        studentContext.Entry(student).State = EntityState.Modified;

        try
        {
            await studentContext.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!StudentExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }
        return NoContent();
    }
    private bool StudentExists(int id)
    {
        return studentContext.StudentsDetailsShenba.Any(e => e.StudentId == id);
        // return studentContext.StudentShenbaORM.Any(e => e.StudentId == id);
    }
}
