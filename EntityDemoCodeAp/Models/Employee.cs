using System.ComponentModel.DataAnnotations;

namespace EntityDemoCodeAp;

public class EmployeeShenbab
{
    [Key]
    public int EmployeeId {get;set;}
    public string? EmployeeName {get;set;}
    public string? Designation {get;set;}
    public double EmployeeSalary {get;set;}
}
