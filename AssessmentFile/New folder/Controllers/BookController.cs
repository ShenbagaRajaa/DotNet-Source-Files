using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssessmentFile;

[Authorize(Roles = "Manager, SalesMan")]
public class BookController : Controller
{
    private readonly BookContext? myBookContext;
    public BookController(BookContext context)
    {
        myBookContext = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await myBookContext.BookDetailsShenba.ToListAsync());
    }

    [Authorize(Roles = "Manager, SalesMan")]
    public IActionResult Create()
    {
        return View();
    }

    [Authorize(Roles = "Manager, SalesMan")]
    [HttpPost]
    public async Task<IActionResult> Create([Bind("BookId,BookName,Author,Generation,Price,StockInHand")] BookDetailsShenba book)
    {
        if (ModelState.IsValid)
        {
            myBookContext.Add(book);
            await myBookContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(book);
    }


    [Authorize(Roles = "Manager, SalesMan")]
    public IActionResult Details()
    {
        return View();
    }

    [Authorize(Roles = "Manager, SalesMan")]
    [HttpPut]
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var book = await myBookContext.BookDetailsShenba
            .FirstOrDefaultAsync(m => m.BookId == id);
        if (book == null)
        {
            return NotFound();
        }

        return View(book);
    }

    [Authorize(Roles = "Manager")]
    [HttpDelete]
    public async Task<IActionResult> Delete(int? id)
    {
        var studentdata = await myBookContext.BookDetailsShenba.FindAsync(id);
        if (studentdata == null)
        {
            return NotFound();
        }
        myBookContext.BookDetailsShenba.Remove(studentdata);
        await myBookContext.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}
