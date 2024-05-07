using Microsoft.EntityFrameworkCore;

namespace EntityDemoCodeAp;

public class EmployeeContext:DbContext
{
    public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options){

    }
    public DbSet<EmployeeShenbab> EmployeeShenbabs{get;set;}
}
