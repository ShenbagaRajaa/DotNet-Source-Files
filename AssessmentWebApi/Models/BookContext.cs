using Microsoft.EntityFrameworkCore;

namespace AssessmentWebApi;

public class BookContext:DbContext
{
    public BookContext(DbContextOptions<BookContext> options):base(options){

    }
    public DbSet<BookDetailsShenba> BookDetailsShenba{get;set;}
}
