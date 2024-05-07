// FileStream Demoobj=new FileStream("D:/.NetCoreee/project1/Files/MyDemo.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.ReadWrite);
// for(byte i=65; i<90; i++){
// Demoobj.WriteByte(i);
// }
// for(int i=1; i<26; i++){
//     Console.WriteLine((char)Demoobj.ReadByte());
// }
// StreamWriter Demowriter=new StreamWriter(Demoobj);
// Console.WriteLine("Enter name");
// Demowriter.WriteLine("Name : "+Console.ReadLine());
// Console.WriteLine("Enter Salary");
// Demowriter.WriteLine("Salary : "+Console.ReadLine());
// Demowriter.Flush();
// Demowriter.Close();
// StreamReader Demoreader=new StreamReader("D:/.NetCoreee/project1/Files/MyDemo.txt");
// // string? DemoData="";
// while(Demoreader.ReadLine()!=null){
//     Console.WriteLine(Demoreader.ReadLine());
// }
// Demoobj.Close();

// File.WriteAllText("D:/.NetCoreee/project1/Files/MyDemo.txt", Console.ReadLine());
// Console.WriteLine(File.ReadAllText("D:/.NetCoreee/project1/Files/MyDemo.txt")); 

// BinaryWriter binaryWriter=new BinaryWriter(File.Open("D:/.NetCoreee/project1/Files/MyDemo2.dat",FileMode.OpenOrCreate));
// binaryWriter.Write("hello");
// binaryWriter.Write(true);
// binaryWriter.Write(98.4d);
// binaryWriter.Close();

// BinaryReader binaryReader=new BinaryReader(File.Open("D:/.NetCoreee/project1/Files/MyDemo2.dat",FileMode.OpenOrCreate));
// Console.WriteLine(binaryReader.ReadString());
// // Console.WriteLine(binaryReader.ReadBoolean());
// Console.WriteLine(binaryReader.ReadDouble());
// binaryReader.Close();

// using System.Runtime.Serialization.Formatters.Binary;

// string myfile1="D:/.NetCoreee/project1/Files/MyDemo3.txt";
// FileStream myFile= new FileStream(myfile1,FileMode.Create);
// BinaryFormatter myFormatter=new BinaryFormatter();

// Employee emp=new Employee();
// emp.empid=Convert.ToInt16(Console.ReadLine());
// emp.empname=Console.ReadLine();
// myFormatter.Serialize(myFile,emp);
// myFile.Close();

// [Serializable]
// public class Employee{
//     public int empid {get; set;}
//     public string empname {get;set;}

// }
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
// using System.Text.Json;

// string myfile1="D:/.NetCoreee/project1/Files/MyDemo3.txt";

// Employee emp=new Employee();
// emp.empid=Convert.ToInt16(Console.ReadLine());
// emp.empname=Console.ReadLine();
// var myserial=JsonSerializer.Serialize<Employee>(emp);
// File.WriteAllText(myfile1,myserial);
// var myreadfile=File.ReadAllText(myfile1);
// Console.WriteLine(myreadfile);

// var mydeserial=JsonSerializer.Deserialize<Employee>(myreadfile);
// Console.WriteLine("id "+mydeserial.empid);
// Console.WriteLine("name "+mydeserial.empname);


// [Serializable]
// public class Employee{
//     public int empid {get; set;}
//     public string empname {get;set;}

// }





//Task 
//question 1

// FileStream price=new FileStream("D:/.NetCoreee/project1/Files/prices.txt",FileMode.OpenOrCreate);
// StreamWriter pricewri=new StreamWriter(price);
// int n=1;
// while(n<5){
// Console.WriteLine("Enter item name");
// pricewri.Write(Console.ReadLine());
// Console.WriteLine("Enter item price");
// pricewri.WriteLine(Console.ReadLine());
// n++;
// }
// pricewri.Close();
// FileStream prices100=new FileStream("D:/.NetCoreee/project1/Files/prices100.txt",FileMode.OpenOrCreate);
// StreamReader priceread=new StreamReader("D:/.NetCoreee/project1/Files/prices.txt");
// StreamWriter pricewri=new StreamWriter(prices100);
// string? DemoData="";
// while((DemoData=priceread.ReadLine())!=null){
//     string[] demo=DemoData.Split(' ');
//     int n1=Convert.ToInt16(demo[1]);
//     if(n1>=100){
//         pricewri.WriteLine(DemoData);
//     }
// }
// pricewri.Close();
// priceread.Close();

//question2
// FileStream word = new FileStream("D:/.NetCoreee/project1/Files/words.txt", FileMode.OpenOrCreate);
// StreamWriter wordwri = new StreamWriter(word);
// Console.WriteLine("Write a sentance");
// string value=Console.ReadLine();
// for(int i=0; i<value.Length; i++){
//     if(char.IsWhiteSpace(value[i])){
//         wordwri.Write("\n");
//     }else{
//         wordwri.Write(value[i]);
//     }
// }
// wordwri.Close();

//question3
// StreamReader wordwri = new StreamReader("D:/.NetCoreee/project1/Files/input.txt");
// string sentance = wordwri.ReadToEnd();
// string[] lines = File.ReadAllLines("D:/.NetCoreee/project1/Files/input.txt");
// int count = 0;
// for (int i = 0; i < lines.Length; i++)
// {
//     for (int j = 0; j < lines[i].Length; j++)
//     {
//         string a = lines[i];
//         if (char.IsWhiteSpace(a[j]))
//         {
//             count++;
//         }
//     }
// }
// Console.WriteLine(count);
// wordwri.Close();

//question4
// StreamReader wordwri = new StreamReader("D:/.NetCoreee/project1/Files/input.txt");
// string sentance = wordwri.ReadToEnd();
// char[] sp={'\n',' '};
// string[] sents=sentance.Split(sp);
// Console.WriteLine(sents.Length);
// wordwri.Close();

//question5
// StreamReader wordwri = new StreamReader("D:/.NetCoreee/project1/Files/input.txt");
// string sentance = wordwri.ReadToEnd();
// char[] sp={'\n',' '};
// string[] sents=sentance.Split('\n');
// int count=0;
// for(int i=0; i<sents.Length; i++){
//     Console.WriteLine(sents[i]);
//     if(sents[i].ToLower().Contains("the")){
//         count++;
//         Console.WriteLine(count);
//     }
// }
// Console.WriteLine(count);
// wordwri.Close();

//example1
// string FilePath = @"D:\MyFile.txt";
// FileStream fileStream = new FileStream(FilePath, FileMode.Append);
// byte[] bytedata = Encoding.Default.GetBytes("C# Is an Object Oriented Programming Language");
// fileStream.Write(bytedata, 0, bytedata.Length);
// fileStream.Close();
// Console.WriteLine("Successfully saved file with data : C# Is an Object Oriented Programming Language");


string FilePath = @"D:\MyFile.txt";
string data;
FileStream fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
using (StreamReader streamReader = new StreamReader(fileStream))
{
    data = streamReader.ReadToEnd();
}
Console.WriteLine(data);