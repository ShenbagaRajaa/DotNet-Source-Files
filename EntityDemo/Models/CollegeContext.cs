using Microsoft.EntityFrameworkCore;

namespace EntityDemo;

public class CollegeContext:DbContext
{
    public CollegeContext(DbContextOptions<CollegeContext> options):base(options){

    }
    public DbSet<StudentShenbaORM> StudentShenbaORM{get;set;}
}
