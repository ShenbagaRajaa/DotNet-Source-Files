using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssessmentWebApi;

[ApiController]
[Route("api/[controller]")]
// [Authorize(Roles = "Manager, SalesMan")]
public class BookController:ControllerBase
{
    private readonly BookContext? myBookContext;
    private readonly ILogger<BookController> _logger;

    public BookController(BookContext context,ILogger<BookController> logger)
    {
        myBookContext = context;
        _logger=logger;
        _logger.LogDebug("Debug Msg");
        _logger.LogInformation("Info msg");
        _logger.LogError("Error msg");
        _logger.LogWarning("Warn msg");
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BookDetailsShenba>>> GetAllBook()
    {
        return await myBookContext.BookDetailsShenba.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<BookDetailsShenba>> GetParticularBook(int id)
    {
         return await myBookContext.BookDetailsShenba.FindAsync(id);
    }


    
    [HttpPost]
    [Authorize(Roles = "Manager, SalesMan")]
    public async Task<ActionResult<BookDetailsShenba>> AddBookDetails(BookDetailsShenba book)
    {
        myBookContext.BookDetailsShenba.Add(book);
        await myBookContext.SaveChangesAsync();
        return CreatedAtAction("GetParticularBook", new { id = book.BookId }, book);
    }


   
    [HttpPut("{id}")]
    [Authorize(Roles = "Manager, SalesMan")]
    public async Task<IActionResult> UpdateBookDetials(int id,BookDetailsShenba book )
    {
        if (id != book.BookId)
        {
            return BadRequest();
        }

        myBookContext.Entry(book).State = EntityState.Modified;

        try
        {
            await myBookContext.SaveChangesAsync();
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
        return myBookContext.BookDetailsShenba.Any(e => e.BookId == id);
        // return studentContext.StudentShenbaORM.Any(e => e.StudentId == id);
    }

    
    [HttpDelete("{id}")]
    [Authorize(Roles = "Manager")]
    public async Task<ActionResult<IEnumerable<BookDetailsShenba>>> Delete(int? id)
    {
        var studentdata = await myBookContext.BookDetailsShenba.FindAsync(id);
        if (studentdata == null)
        {
            return NotFound();
        }
        myBookContext.BookDetailsShenba.Remove(studentdata);
        await myBookContext.SaveChangesAsync();
        return await myBookContext.BookDetailsShenba.ToListAsync();
    }
}
