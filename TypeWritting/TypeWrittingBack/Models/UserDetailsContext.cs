
using Microsoft.EntityFrameworkCore;
using ZstdSharp.Unsafe;

namespace TypeWrittingBack.Models;

public class UserDetailsContext : DbContext
{
    public UserDetailsContext(DbContextOptions<UserDetailsContext> options) : base(options)
    {

    }

    public DbSet<UserDetailsShenba> UserDetailsShenba { get; set; }
    public DbSet<MachineShenba> MachineShenba { get; set; }
    public DbSet<StudentsDetailsShenba> StudentsDetailsShenba { get; set; }
    public DbSet<EmployeesDetailsShenba> EmployeesDetailsShenba {get;set;}
}