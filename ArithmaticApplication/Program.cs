using System.ComponentModel;
// using MathsComponent;
using MathsFactory;
using MathsInterface;

// Arithmatic arith=new Arithmatic();

Console.WriteLine("enter 2 no");
int n1=Convert.ToInt16(Console.ReadLine());
int n2=Convert.ToInt16(Console.ReadLine());
IAinterface arith=AFactory.CreateAOperation();
Console.WriteLine("add "+arith.add(n1,n2));
Console.WriteLine("sub "+arith.sub(n1,n2));
