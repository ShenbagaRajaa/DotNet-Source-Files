namespace Task1MarkCalc;

//question 4 and 5
public class StudentDetails1
{
    int studentid;
    string? studentname;
    string? department;
    string? year;
    long mobileno;
    string? city;
    public int StudentId { get { return studentid; }set{studentid=value;} }
    public string? StudentName { get { return studentname; }set{studentname=value;} }
    public string? Department { get { return department; } set{department=value;}}
    public string? Year { get { return year; } set{year=value;}}
    public long MobileNo { get { return mobileno; } set{mobileno=value;}}
    public string? City { get { return city; } set{city=value;}}

    public StudentDetails1(int studentid, string? studentname, string? deparment, string? year, long mobileno, string? city)
    {
        this.studentid = studentid;
        this.studentname = studentname;
        this.department = deparment;
        this.year = year;
        this.mobileno = mobileno;
        this.city = city;
    }
    public StudentDetails1(){}
    public void GetDetails()
    {
        Console.WriteLine("Enter Student Id");
        StudentId = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter Student Name");
        StudentName = Console.ReadLine();
        Console.WriteLine("Enter Department");
        Department = Console.ReadLine();
        Console.WriteLine("Enter Year");
        Year = Console.ReadLine();
        Console.WriteLine("Enter Mobile number");
        MobileNo = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Enter school name");
        City = Console.ReadLine();
    }
    public void Display()
    {
        Console.WriteLine("Student Id " + StudentId);
        Console.WriteLine("Student Name " + StudentName);
        Console.WriteLine("Department " + Department);
        Console.WriteLine("Year " + Year);
        Console.WriteLine("Mobile Number " + MobileNo);
        Console.WriteLine("City " + City);
    }
}





//question2 and 3
public class StudentDetails
{
    string? studentname;
    string? emailid;
    long mobileno;
    double percentage;
    string? schoolname;
    public string? StudentName { get { return studentname; } }
    public string? EmailId { get { return emailid; } }
    public long MobileNo { get { return mobileno; } }
    public double Percentage { get { return percentage; } }
    public string? SchoolName { get { return schoolname; } }

    public StudentDetails(string? studentname, string? emailid, long mobileno, double percentage, string? schoolname)
    {
        this.studentname = studentname;
        this.emailid = emailid;
        this.mobileno = mobileno;
        this.percentage = percentage;
        this.schoolname = schoolname;
    }

    public void display()
    {
        Console.WriteLine("Student Name " + StudentName);
        Console.WriteLine("Email ID " + EmailId);
        Console.WriteLine("Mobile Number " + MobileNo);
        Console.WriteLine("Percentage " + Percentage);
        Console.WriteLine("SchoolName " + SchoolName);
    }
}






//question 1
public class MarkCalculation
{
    double mark1;
    double mark2;
    double mark3;
    double mark4;
    double mark5;

    public double Mark1 { get { return mark1; } }
    public double Mark2 { get { return mark2; } }
    public double Mark3 { get { return mark3; } }
    public double Mark4 { get { return mark4; } }
    public double Mark5 { get { return mark5; } }

    public MarkCalculation(double m1, double m2, double m3, double m4, double m5)
    {
        mark1 = m1; mark2 = m2; mark3 = m3; mark4 = m4; mark5 = m5;
    }

    public double PercentageCalculation()
    {
        return (mark1 + mark2 + mark3 + mark4 + mark5) / 5;
    }

    public void display()
    {
        Console.WriteLine("Mark 1 " + Mark1);
        Console.WriteLine("Mark 2 " + Mark2);
        Console.WriteLine("Mark 3 " + Mark3); Console.WriteLine("Mark 4 " + Mark4);
        Console.WriteLine("Mark 5 " + Mark5); Console.WriteLine("Percentage " + PercentageCalculation());
    }
}

