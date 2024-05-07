using Microsoft.EntityFrameworkCore;

namespace AssessmentMVC;

public class EmployeeContext:DbContext
{
    public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options){

    }  
    public DbSet<EmployeeAsShenba> EmployeeAsShenba {get;set;}
}
