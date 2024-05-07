using System.Transactions;
using Task1StudentDetialsInfo;
using Task1AcademicInfo;
//question 1
MarkCalculation mobj; 
Console.WriteLine("Enter 5 marks");
double m1=Convert.ToDouble(Console.ReadLine());
double m2=Convert.ToDouble(Console.ReadLine());
double m3=Convert.ToDouble(Console.ReadLine());
double m5=Convert.ToDouble(Console.ReadLine());
double m4=Convert.ToDouble(Console.ReadLine());
mobj = new MarkCalculation(m1,m2,m3,m4,m5);
mobj.display();

// //question 2
// Console.WriteLine("Enter Student Name");
// string? studname=Console.ReadLine();
// Console.WriteLine("Enter Email id");
// string? emailid=Console.ReadLine();
// Console.WriteLine("Enter Mobile number");
// long mobno=Convert.ToInt64(Console.ReadLine());
// Console.WriteLine("Enter Pecentage");
// double percent=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter school name");
// string? sclname=Console.ReadLine();
// StudentDetails studentObj = new StudentDetails(studname,emailid,mobno,percent,sclname);
// studentObj.display();

// //question 3
// Console.WriteLine("Enter how many number of student details you want to store?");
// int n = Convert.ToInt16(Console.ReadLine());
// StudentDetails[] studentObj = new StudentDetails[n];
// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine("Enter Student Name");
//     string? StudentName = Console.ReadLine();
//     Console.WriteLine("Enter Email id");
//     string? EmailId = Console.ReadLine();
//     Console.WriteLine("Enter Mobile number");
//     long MobileNo = Convert.ToInt64(Console.ReadLine());
//     Console.WriteLine("Enter Pecentage");
//     double Percentage = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Enter school name");
//     string? SchoolName = Console.ReadLine();
//     studentObj[i] = new StudentDetails(StudentName,EmailId,MobileNo,Percentage,SchoolName);
// }
// foreach (StudentDetails i in studentObj)
// {
//     Console.WriteLine("Student Name"+i.StudentName);
//     Console.WriteLine("Email id"+i.EmailId);
//     Console.WriteLine("Mobile number"+i.MobileNo);
//     Console.WriteLine("Pecentage"+i.Percentage);
//     Console.WriteLine("school name"+i.SchoolName);
// }


// //question 4 and 5
// Console.WriteLine("Enter how many number of student details you want to store?");
// int n = Convert.ToInt16(Console.ReadLine());
// StudentDetails1[] studentObj1 = new StudentDetails1[n];
// for (int i = 0; i < n; i++)
// {
// Console.WriteLine("Enter Student Id");
// int StudentId = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine("Enter Student Name");
// string? StudentName = Console.ReadLine();
// Console.WriteLine("Enter Department");
// string? Department = Console.ReadLine();
// Console.WriteLine("Enter Year");
// string? Year = Console.ReadLine();
// Console.WriteLine("Enter Mobile number");
// long MobileNo = Convert.ToInt64(Console.ReadLine());
// Console.WriteLine("Enter school name");
// string? City = Console.ReadLine();
// studentObj1[i] = new StudentDetails1(StudentId, StudentName,Department,Year, MobileNo, City);
// }
// for (int i=0; i<n; i++)
// {
//     studentObj1[i].Display();
// }

// //question 7
// StudentDetails1 studentObj2 = new StudentDetails1();
// studentObj2.GetDetails();
// studentObj2.Display();

// //question 6 and 8
// AcademicInfo academic=new AcademicInfo();
// academic.GetAcademicDetails();
// academic.ShowAcademicDetails();

// //question 9
// StudentInfo studentinfo=new StudentInfo();
// studentinfo.ShowDetails();

// public class clsname :hello{
//     public void hell(){
        
//     }
// }
// public interface hello{
//     public void hell();
// }
