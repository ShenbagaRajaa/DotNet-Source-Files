using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

// List<string> list= new List<string>();
// list.Add("hello");
// list.Add("Hai");
// list.Add("Hi");

// HashSet<string> list1= new HashSet<string>();

// Stack<string> list2= new Stack<string>();

// Queue<string> list3= new Queue<string>();

// LinkedList<string> list4= new LinkedList<string>();

// GenericCD<int> obj=new GenericCD<int>(10);
// obj.Show();

// class GenericCD<T>{
//     T value;
//     public GenericCD(T value){
//         this.value=value;
//     }
//     public void Show(){
//         Console.WriteLine("This "+value);
//     }
// }

// public interface Arith<T>{
//     public T showData();
//     public void Dsipaly(T n1, T n2);
// }

// List<Employee> emp=new List<Employee>();
// while(true){
// Console.WriteLine("enter");
// int id=Convert.ToInt16(Console.ReadLine());
// string name=Console.ReadLine();
// emp.Add(new Employee(id,name));
// if(emp.Count==3){
//     break;
// }
// }
// foreach (Employee e in emp){
//     Console.WriteLine(e.empid +" " +e.empname);
// }
// class Employee{
//     public int empid {get;}
//     public string empname {get;}
//     public Employee(int id, string name){
//         empid=id;
//         empname=name;
//     }
//     // public override string ToString()
//     // {
//     //     return $"Empid {empid} empname {empname}";
//     // }
// }

// var names = new List<string>(){
//     "A","B","C"
// };
// ICollection<string> mycoll=names;
// names.Add("D");
// mycoll.Add("E");
// foreach(string i in names){
//     Console.WriteLine(i);
// }

int[] num = new int[] { 10, 2, 6, 15, 52, 36, 81, 20 };
var result = from n in num where n < 25 orderby n select n;
foreach(int i in result){
    Console.WriteLine(i);
}































// using System.Collections;

// SortedList so=new SortedList();
// so.Add(1,"hello");
// so.Add(25,"hi");
// so.Add(5,"Hai");

// // Console.WriteLine(so.AsParallel());
// // Console.WriteLine(so.AsQueryable());
// Console.WriteLine(so.GetValueList());
// Console.WriteLine(so.Contains(1));
// Console.WriteLine(so.ContainsKey(1));
// Console.WriteLine(so.ContainsValue(1));
// Console.WriteLine(so.Capacity);
// so.Remove(1);
// so.RemoveAt(2);
// so.Clear();
// // foreach(DictionaryEntry obj in so){
// //     Console.WriteLine(obj.Value+","+obj.Key);
// // }

// ArrayList moblist = new ArrayList();
// moblist.Add("Apple");
// moblist.Add("Oppo");
// moblist.Add("Vivo");
// moblist.Add("Realme");
// moblist.Add("Redme");

// ArrayList lablist=new ArrayList();
// lablist.Add("Hp");
// lablist.Add("Dell");
// lablist.Add("Acer");
// lablist.Add("Lenova");
// lablist.Add("Apple");

// moblist.AddRange(lablist);
// foreach(dynamic obj in moblist){
//     Console.WriteLine(obj);
// }
// Console.WriteLine("-----------------------");
// moblist.Remove("Redme");
// foreach(dynamic obj in moblist){
//     Console.WriteLine(obj);
// }