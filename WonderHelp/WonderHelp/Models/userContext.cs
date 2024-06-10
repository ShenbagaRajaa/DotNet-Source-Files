using Microsoft.EntityFrameworkCore;

namespace WonderHelp;

public class userContext:DbContext
{
    public userContext(DbContextOptions<userContext> options) : base(options)
    {

    }

    public DbSet<user_details> user_details { get; set; }
    // public DbSet<client> client {get; set;}
    // public DbSet<article> article {get; set;}
}
