using System.ComponentModel.DataAnnotations;

namespace AssessmentMVC;

public class EmployeeAsShenba
{
    [Key]
    public int EmployeeId { get; set; }
    public string? EmployeeName { get; set; }
    public string? EmployeeDesignation { get; set; }
    public double EmployeeSalary { get; set; }
    public DateTime EmployeeDoJ { get; set; }
}
