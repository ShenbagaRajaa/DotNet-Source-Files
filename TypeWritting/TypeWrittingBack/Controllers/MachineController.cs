using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TypeWrittingBack.Models;
using System.Linq;

namespace TypeWrittingBack;

[ApiController]
[Route("api/[controller]")]

public class MachineController : ControllerBase
{
    private readonly UserDetailsContext userContext;
    public MachineController(UserDetailsContext context)
    {
        userContext = context;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<IEnumerable<MachineShenba>>> GetAllMachineDetials()
    {
        return await userContext.MachineShenba.ToListAsync();
    }

    [HttpGet("GetById/{id}")]
    public async Task<ActionResult<MachineShenba>> GetParticularMachine(int id)
    {
        return await userContext.MachineShenba.FindAsync(id);
    }

    [HttpGet("maxId")]
    public async Task<IActionResult> GetMaxValue()
    {
        var maxId = await userContext.MachineShenba.MaxAsync(p => p.Id);
        return Ok(maxId);
    }

    [HttpPost("AddNewMachine")]
    public async Task<ActionResult<MachineShenba>> AddMachine(MachineShenba machine)
    {
        userContext.MachineShenba.Add(machine);
        await userContext.SaveChangesAsync();
        return CreatedAtAction("GetParticularMachine", new { id = machine.Id }, machine);
    }

    [HttpDelete("DeleteById/{id}")]
    public async Task<ActionResult<IEnumerable<MachineShenba>>> DeleteMachine(int id)
    {
        var studentdata = await userContext.MachineShenba.FindAsync(id);
        if (studentdata == null)
        {
            return NotFound();
        }
        userContext.MachineShenba.Remove(studentdata);
        await userContext.SaveChangesAsync();
        return await userContext.MachineShenba.ToListAsync();
        // return NoContent();
    }
}
