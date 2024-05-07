using System.Security.Policy;
using System.ComponentModel.DataAnnotations;

namespace EntityDemo;

public class StudentShenbaORM
{
    [Key] //studentid is a primarykey so declare 'key'
    public int StudentId{get;set;}
    // [Required(ErrorMessage ="Enter a name")]
    public string? StudentName{get;set;}
    public int DepartmentId{get;set;}
    public string? Gender{get;set;}
    public string? EmailId{get;set;}
}
