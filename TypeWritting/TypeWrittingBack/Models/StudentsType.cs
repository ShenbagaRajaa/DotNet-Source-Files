using System.ComponentModel.DataAnnotations;

namespace TypeWrittingBack.Models;

public class UserDetailsShenba{
    [Key]
    public int StudentId { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Type{get; set;}
    public string PasswordSalt { get; set; }
    public string PasswordHash { get; set; }
}

public class frontenduser {
    public string Username { get; set; }
    public string Email { get; set; }
    public string Type{get; set;}
    public string Password { get; set; }
}

public class frontendLogin {
    public string Username { get; set; }
    public string Password { get; set; }
    public string Type{get; set;}
}

public class MachineShenba {
    public int Id {get;set;}
    public string MachineId{get; set;}
    public string MachineLanguage {get; set;}
}

public class StudentsDetailsShenba{
    [Key]
    public int StudentId { get; set; }
    public string UserName { get; set; }
    public string StudentName { get; set; }
    public string Email { get; set; }
    public long PhoneNo {get;set;}
    public string Language {get;set;}
    public string MachineId{get;set;}
    public string Designation {get;set;}

}

public class EmployeesDetailsShenba{
    [Key]
    public int EmployeeId { get; set; }
    public string UserName { get; set; }
    public string EmployeeName { get; set; }
    public string Email { get; set; }
    public long PhoneNo {get;set;}
    public string Designation {get;set;}
    public string PasswordSalt { get; set; }
    public string PasswordHash { get; set; }
}

public class frontendEmployee {
    public string UserName { get; set; }
    public string EmployeeName { get; set; }
    public string Email { get; set; }
    public long PhoneNo {get;set;}
    public string Designation {get;set;}
    public string Password { get; set; }
}







