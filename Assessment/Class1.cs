namespace Assessment;

public class Class1
{




































// using System.ComponentModel.DataAnnotations;
// using System.IO.Pipes;
// using System.Numerics;
// using System.Reflection.Metadata;

// using System.Net;

// string hell=Dns.GetHostName();
// Console.WriteLine(hell);
// IPHostEntry he=Dns.GetHostEntry(hell);
// IPAddress[] iparr=he.AddressList;
// for(int i=0; i<iparr.Length; i++){
//     Console.WriteLine("ip address {0}:{1}",i+1);
// }

// Discount discountdel = new Discount(Discount);
// ICustomer CustomerObj = new Customer();
// Product ProductObj = new Product();
// Hotal HotelObj = new Hotal();

// CustomerObj.GetCustomerDetails();
// double coupon1=0;
// a:
// try
// {
//     Console.WriteLine("If Customer have Coupon card then enter 'y' don't have then 'n'");
//     char coupon = Convert.ToChar(Console.ReadLine());
//     switch (coupon)
//     {
//         case 'y':
//             coupon1=3;
//             break;
//         case 'n':
//             break;
//         default:
//             throw new InvalidOptionException("Please enter valid option");
//     }
// }
// catch (InvalidOptionException ex)
// {
//     Console.WriteLine(ex.Message);
//     goto a;
// }
// catch (FormatException ex)
// {
//     Console.WriteLine(ex.Message);
//     goto a;
// }

// b:
// ProductObj.GetProductDetails();
// try
// {
//     Console.WriteLine("Do you want to add one more Product then enter 'y' don't have then 'n'");
//     char addproduct = Convert.ToChar(Console.ReadLine());
//     switch (addproduct)
//     {
//         case 'y':
//             goto b;
//         case 'n':
//             break;
//         default:
//             throw new InvalidOptionException("Please enter valid option");
//     }
// }
// catch (InvalidOptionException ex)
// {
//     Console.WriteLine(ex.Message);
//     goto b;
// }
// catch (FormatException ex)
// {
//     Console.WriteLine(ex.Message);
//     goto b;
// }
// double discount;
// try
// {
//     Console.WriteLine("Enter a discount");
//     discount = Convert.ToDouble(Console.ReadLine());
// }
// catch (FormatException ex)
// {
//     Console.WriteLine(ex.Message);
//     goto b;
// }

// ProductObj.caluculate(discount,coupon1,discountdel);
// // ProductObj.DisplayDetails();
// HotelObj.ShowBill();





// double Discount(double rate,double discount)
// {
//     return rate - (rate * (discount/100));
// }

// public delegate double Discount(double rate, double discount);
// public interface ICustomer
// {
//     public void GetCustomerDetails();
// }
// public interface IProduct
// {
//     public void GetProductDetails();
// }
// public interface IHotel
// {
//     public void ShowBill();
// }
// class Hotal : Product, IHotel
// {
//     public void ShowBill()
//     {
//         string str="D:/.NetCoreee/project1/Files/file1.txt";
//         // StreamReader strrea=new StreamReader("D:/.NetCoreee/project1/Files/file1.txt");
//         string[] bill=File.ReadAllLines(str);
//         foreach(string b in bill){
//             Console.WriteLine(b);
//         }
//     }
    
// }
// class Customer : ICustomer
// {
//     string CusName;
//     long CusMobile;
//     public string CustomerName { get { return CusName; } set { CusName = value; } }
//     public long CustomerMobile { get { return CusMobile; } set { CusMobile = value; } }
//     public Customer() { }
//     public Customer(string customername, long mobile)
//     {
//         this.CustomerName = customername;
//         this.CustomerMobile = mobile;
//     }
//     public void GetCustomerDetails()
//     {
//         Console.WriteLine("Enter Customer Name");
//         CustomerName = Console.ReadLine();
//     cmobile:
//         try
//         {
//             Console.WriteLine("Enter Customer Mobile number");
//             CustomerMobile = Convert.ToInt64(Console.ReadLine());
//         }
//         catch (FormatException ex)
//         {
//             Console.WriteLine(ex.Message);
//             goto cmobile;
//         }
//     }
// }
// class Product : IProduct
// {
//     int Protid;
//     string ProtName;
//     double ProtRate;
//     int ProtQuan;
//     public double totalamt;
//     public int ProductId { get { return Protid; } set { Protid = value; } }
//     public string ProductName { get { return ProtName; } set { ProtName = value; } }
//     public double ProductRate { get { return ProtRate; } set { ProtRate = value; } }
//     public int ProductQuantity { get { return ProtQuan; } set { ProtQuan = value; } }
//     public List<Product> productdetails = new List<Product>();
//     public Product() { }
//     public Product(int id, string proname, double rate, int qun)
//     {
//         this.ProductId = id; this.ProductName = proname; this.ProductRate = rate;
//         this.ProductQuantity = qun;
//     }
//     public void GetProductDetails()
//     {
//     pid:
//         try
//         {
//             Console.WriteLine("Enter Product Id");
//             ProductId = Convert.ToInt16(Console.ReadLine());
//         }
//         catch (FormatException ex)
//         {
//             Console.WriteLine(ex.Message);
//             goto pid;
//         }
//         Console.WriteLine("Enter Product Name");
//         ProductName = Console.ReadLine();
//     prate:
//         try
//         {
//             Console.WriteLine("Enter Product Rate");
//             ProductRate = Convert.ToDouble(Console.ReadLine());
//         }
//         catch (FormatException ex)
//         {
//             Console.WriteLine(ex.Message);
//             goto prate;
//         }
//     pq:
//         try
//         {
//             Console.WriteLine("Enter Product Quantity");
//             ProductQuantity = Convert.ToInt16(Console.ReadLine());
//         }
//         catch (FormatException ex)
//         {
//             Console.WriteLine(ex.Message);
//             goto pq;
//         }
//         productdetails.Add(new Product(ProductId, ProductName, ProductRate, ProductQuantity));
//     }
//     public void DisplayDetails()
//     {
//         var result = from n in productdetails orderby n.ProductId select n;
//         foreach (Product i in productdetails)
//         {
//             Console.WriteLine("Prodcut Id : "+i.ProductId+", Product name : "+i.ProductName+", Product Rate : "+i.ProductRate+ " Product Quantity : "+i.ProductQuantity);
//         }
//     }
//     readonly Customer cusobj=new();
//     public void caluculate(double discount,double coupon1,Discount discountdel)
//     {
//         totalamt = 0;
//         foreach (Product pro in productdetails)
//         {
//             totalamt = totalamt + (pro.ProductRate * Convert.ToDouble(pro.ProductQuantity));
//         }
//         totalamt=discountdel(totalamt,discount);
//         totalamt=totalamt-(totalamt*(coupon1/100));
//         FileStream filestr= new FileStream("D:/.NetCoreee/project1/Files/file1.txt",FileMode.OpenOrCreate);
//         StreamWriter strwri= new StreamWriter(filestr);
//         strwri.WriteLine("Customer Name : "+cusobj.CustomerName);
//         strwri.WriteLine("Customer Mobile" + cusobj.CustomerMobile);
//         strwri.WriteLine("Product Name\tRate\tQty");
//         strwri.WriteLine("---------------------------------------");
//         foreach (Product pro in productdetails)
//         {
//             strwri.WriteLine(pro.ProductName+"\t"+pro.ProductRate +"\t"+ pro.ProductQuantity);  
//         }
//         strwri.WriteLine("---------------------------------------");
//         strwri.WriteLine("Total Amt : "+totalamt);
//         strwri.Write("---------------------------------------");
//         strwri.Close();
//         filestr.Close();
//     }
// }
// class InvalidOptionException : Exception
// {
//     public InvalidOptionException() { }
//     public InvalidOptionException(string msg) : base(msg) { }
// }








































// // BookEntry book = new BookEntry();
// // Console.WriteLine("How many number of Book details you want to enter now? ");
// // int n = Convert.ToInt32(Console.ReadLine());
// // int i = 1;
// // while (i <= n)
// // {
// //     book.GetBookDetails();
// //     i++;
// // }
// // book.DisplayBookDetails();

// // public interface IBookEntry
// // {
// //     public void GetBookDetails();
// //     public void DisplayBookDetails();
// // }
// // public class BookEntry : IBookEntry
// // {
// //     string? Bname;
// //     string? Bauthor;
// //     string? Bpublication;
// //     DateTime Bpdate;
// //     public string? BookName { get { return Bname; } set { Bname = value; } }
// //     public string? BookAuthor { get { return Bauthor; } set { Bauthor = value; } }
// //     public string? BookPublication { get { return Bpublication; } set { Bpublication = value; } }
// //     public DateTime BookPublicationDate { get { return Bpdate; } set { Bpdate = value; } }
// //     public BookEntry() { }
// //     public BookEntry(string bname, string bauthor, string bpublication, DateTime bpdate)
// //     {
// //         this.BookName = bname;
// //         this.BookAuthor = bauthor;
// //         this.BookPublication = bpublication;
// //         this.BookPublicationDate = bpdate;
// //     }
// //     List<BookEntry> BookDetails = new List<BookEntry>();
// //     public void GetBookDetails()
// //     {
// //         Console.WriteLine("Enter Book name");
// //         BookName = Console.ReadLine();
// //         Console.WriteLine("Enter Book Author Name");
// //         BookAuthor = Console.ReadLine();
// //         Console.WriteLine("Enter Book Publication Name");
// //         BookPublication = Console.ReadLine();
// //         Console.WriteLine("Enter Book Publication Date (YYYY-MM-DD)");
// //         BookPublicationDate = Convert.ToDateTime(Console.ReadLine());
// //         BookDetails.Add(new BookEntry(BookName, BookAuthor, BookPublication, BookPublicationDate));
// //     }
// //     public void DisplayBookDetails()
// //     {
// //         var result = from n in BookDetails orderby n.BookName select n;
// //         foreach (BookEntry i in result)
// //         {
// //             Console.WriteLine("Book Name : "+i.BookName+", Author : "+i.BookAuthor+", Publication : "+i.BookPublication+", Publish Date : "+i.BookPublicationDate);
// //         }
// //     }
// // }

}
