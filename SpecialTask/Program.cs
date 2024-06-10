// //Create a class that accept with the property name , id , dob ,doj, and sal we have to 
// //encapsulate and that class we have to implemnt iemployee that has memeber functions getempdetails,
// //showempdetails and sortempdetails your have to sort if user ask with name then sort by name, if ask 
// //with experience then sort by doj, like age, salary have to handle exception want to create user defined 
// //exception for name and age, name have only letter, for the age check min age is 22. message 'dob must 
// //before apr 2002' when one emp data entered then we get a msg
// using System.Text.RegularExpressions;

// Employee emp = new Employee();
// int n = 1;
// while (n <= 2)
// {
//     n++;
//     addsuccess successobj = new addsuccess(success);
//     emp.GetEmployeeDetails(successobj);
// }
// bool b1 = true;
// while (b1)
// {
//     try{
//     Console.WriteLine("--------------------------------------------");
//     Console.WriteLine("Press 1 : Show Employee Details");
//     Console.WriteLine("Press 2 : Show Employee Details Sorted Order");
//     Console.WriteLine("Press 3 : Stop Process");
//     Console.WriteLine("--------------------------------------------");
//     int op = Convert.ToInt32(Console.ReadLine());
//     switch (op)
//     {
//         case 1:
//             emp.ShowEmployeeDetials();
//             continue;
//         case 2:
//             emp.SortEmployeeDetials();
//             continue;
//         case 3:
//             Console.WriteLine("Thanks for using");
//             b1 = false;
//             break;
//         default:
//             Console.WriteLine("Invalid Option");
//             continue;
//     }
//     }catch(FormatException ex){
//         Console.WriteLine(ex.Message);
//     }
// }

// void success(string name)
// {
//     Console.WriteLine("Employee " + name + " details added successfully");
// }
// public delegate void addsuccess(string name);
// public interface IEmployee
// {
//     public void GetEmployeeDetails(addsuccess obj);
//     public void ShowEmployeeDetials();
//     public void SortEmployeeDetials();
// }
// public class Employee : IEmployee
// {
//     int EmpId;
//     string? EmpName;
//     DateTime DOB;
//     int Age;
//     DateTime DOJ;
//     int Experience;
//     double Salary;

//     public int EmployeeId { get { return EmpId; } set { EmpId = value; } }
//     public string? EmployeeName { get { return EmpName; } set { EmpName = value; } }
//     public DateTime DateofBirth { get { return DOB; } set { DOB = value; } }
//     public int EmployeeAge { get { return Age; } set { Age = value; } }
//     public DateTime DateofJoin { get { return DOJ; } set { DOJ = value; } }
//     public int EmployeeExperience { get { return Experience; } set { Experience = value; } }
//     public double EmployeeSalary { get { return Salary; } set { Salary = value; } }
//     public Employee() { }
//     public Employee(int id, string name, DateTime dob, int age, DateTime doj, int exp, double sal)
//     {
//         this.EmployeeId = id; this.EmployeeName = name; this.DateofBirth = dob; this.EmployeeAge = age;
//         this.DateofJoin = doj; this.EmployeeExperience = exp; this.EmployeeSalary = sal;
//     }
//     List<Employee> Empdetails = new List<Employee>();

//     public void GetEmployeeDetails(addsuccess sucobj)
//     {
//         Console.WriteLine("Enter Employee Id");
//         EmployeeId = Convert.ToInt32(Console.ReadLine());
//     a:
//         Console.WriteLine("Enter Employee Name");
//         EmployeeName = Console.ReadLine();
//         try
//         {
//             ValidateName(EmployeeName);
//         }
//         catch (InvalidNameException ex)
//         {
//             Console.WriteLine(ex.Message);
//             goto a;
//         }
//     b:
//         Console.WriteLine("Enter Employee Date of Birth");
//         DateofBirth = Convert.ToDateTime(Console.ReadLine());
//         try
//         {
//             EmployeeAge = CalculateAge(DateofBirth);
//         }
//         catch (AgeRestrictionException ex)
//         {
//             Console.WriteLine(ex.Message);
//             goto b;
//         }
//         Console.WriteLine("Enter Employee Date of Joining");
//         DateofJoin = Convert.ToDateTime(Console.ReadLine());
//         EmployeeExperience = CalculateExperience(DateofJoin);
//         Console.WriteLine("Enter Employee Salary");
//         EmployeeSalary = Convert.ToDouble(Console.ReadLine());
//         Empdetails.Add(new Employee(EmployeeId, EmployeeName, DateofBirth, EmployeeAge, DateofJoin, EmployeeExperience, EmployeeSalary));
//         sucobj(EmployeeName);
//     }
//     public void ShowEmployeeDetials()
//     {
//         Console.WriteLine("Employee Id  Employee Name   Employee Age    Employee Experience Employee Salary");
//         foreach (Employee empl in Empdetails)
//         {
//             Console.WriteLine(empl.EmployeeId + "  " + empl.EmployeeName + "  " + empl.EmployeeAge + "  " + empl.EmployeeExperience + " " + empl.EmployeeSalary);
//         }
//     }
//     public void SortEmployeeDetials()
//     {
//         bool b = true;
//         while (b)
//         {
//             try
//             {
//                 Console.WriteLine("--------------------------------------------");
//                 Console.WriteLine("Press 1 : Order by Name");
//                 Console.WriteLine("Press 2 : Order by Age");
//                 Console.WriteLine("Press 3 : Order by Experience");
//                 Console.WriteLine("Press 4 : Order by Salary");
//                 Console.WriteLine("Press 5 : Back");
//                 Console.WriteLine("--------------------------------------------");
//                 int op = Convert.ToInt32(Console.ReadLine());
//                 var result = from n in Empdetails orderby n.EmployeeId select n;
//                 switch (op)
//                 {
//                     case 1:
//                         result = from n in Empdetails orderby n.EmployeeName select n;
//                         break;
//                     case 2:
//                         result = from n in Empdetails orderby n.EmployeeAge descending select n;
//                         break;
//                     case 3:
//                         result = from n in Empdetails orderby n.EmployeeExperience descending select n;
//                         break;
//                     case 4:
//                         result = from n in Empdetails orderby n.EmployeeSalary descending select n;
//                         break;
//                     case 5:
//                         b = false;
//                         break;
//                     default:
//                         Console.Write("Ivalid Option");
//                         SortEmployeeDetials();
//                         break;
//                 }
//                 foreach (Employee i in result)
//                 {
//                     Console.WriteLine(i.EmployeeId + " " + i.EmployeeName + " " + i.EmployeeAge + " " + i.EmployeeExperience + " " + i.EmployeeSalary);
//                 }
//             }
//             catch (FormatException ex)
//             {
//                 Console.WriteLine(ex.Message);
//             }
//         }
//     }
//     public int CalculateAge(DateTime DateOfBirth)
//     {
//         Age = 0;
//         Age = DateTime.Now.Year - DateOfBirth.Year;
//         Console.WriteLine(DateOfBirth);
//         if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
//             Age = Age - 1;
//         if (Age < 22)
//             throw new AgeRestrictionException("Age must have above 22");
//         return Age;
//     }
//     public int CalculateExperience(DateTime DateOfJoin)
//     {
//         Experience = 0;
//         Experience = DateTime.Now.Year - DateOfJoin.Year;
//         if (DateTime.Now.DayOfYear < DateOfJoin.DayOfYear)
//             Experience = Experience - 1;
//         return Experience;
//     }
//     public void ValidateName(string name)
//     {
//         Regex Namevalidate = new Regex("^[a-zA-Z ]+$");
//         if (string.IsNullOrWhiteSpace(name))
//             throw new InvalidNameException("Name cannot be empty or null.");
//         else if (!Namevalidate.IsMatch(name))
//         {
//             throw new InvalidNameException("Name cannot contain number or symbols.");
//         }
//     }
// }
// public class InvalidNameException : Exception
// {
//     public InvalidNameException() { }
//     public InvalidNameException(string message) : base(message) { }
//     // public InvalidNameException(string message, Exception inner) : base(message, inner) { }
// }
// public class AgeRestrictionException : Exception
// {
//     public AgeRestrictionException() { }
//     public AgeRestrictionException(string message) : base(message) { }
//     // public AgeRestrictionException(string message, Exception inner) : base(message, inner) { }
// }


using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

Console.Write("Enter a password: ");
string? password = Console.ReadLine();

// Generate a 128-bit salt using a sequence of
// cryptographically strong random bytes.
byte[] salt = RandomNumberGenerator.GetBytes(128 / 8); // divide by 8 to convert bits to bytes
Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");

// derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
    password: password!,
    salt: salt,
    prf: KeyDerivationPrf.HMACSHA256,
    iterationCount: 100000,
    numBytesRequested: 256 / 8));

Console.WriteLine($"Hashed: {hashed}");