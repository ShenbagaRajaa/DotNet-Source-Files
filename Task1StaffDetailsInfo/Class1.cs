using Task1Interface;

namespace Task1StaffDetailsInfo;

public class StaffDetailsInfo
{
    int staffid;
    string? staffname;
    string? mailid;
    long contact;
    int experienceinfield;
    int yearexperience;
    string? city;
    int deptid;
    public int StaffId {get{return staffid;}set{staffid=value;}}
    public string? StaffName {get{return staffname;}set{staffname=value;}}
    public string? MailId {get {return mailid;} set{mailid=value;}}
    public long Contact {get {return contact;} set{contact=value;}}
    public int ExperienceInField {get{return experienceinfield;}set{experienceinfield=value;}}
    public int YearExperience {get{return yearexperience;}set{yearexperience=value;}}
    public string? City {get {return city;} set{city=value;}}
    public int DeptId {get{return deptid;}set{deptid=value;}}
}

public class StaffDetails:StaffDetailsInfo,PersonalDetails{
    public void GetPersonalDetails(){
        Console.WriteLine("Enter Staff id");
        base.StaffId=Convert.ToInt16(Console.ReadLine());
      
        Console.WriteLine("Enter Staff Name");
        base.StaffName = Console.ReadLine();
        Console.WriteLine("Enter Department");
       base.DeptId = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter Year");
        base.YearExperience = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter Mobile number");
        base.Contact = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Enter City name");
        base.City = Console.ReadLine();
    }
    public void ShowPersonalDetails(){
Console.WriteLine("Staff Id " + StaffId);
        Console.WriteLine("Staff Name " + StaffName);
        Console.WriteLine("Department Id" + DeptId);
        Console.WriteLine("Year " + YearExperience);
        Console.WriteLine("Mobile Number " + Contact);
        Console.WriteLine("City " + City);
    }
}