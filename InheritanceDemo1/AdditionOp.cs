namespace InheritanceDemo1;

public class AdditionOp
{
    int n1=10, n2=20;
    public int add(){
        return n1+n2;
    }
    public int add(int n1, int n2){
        return n1+n2;
    }
    public float add(float n1, float n2){
        return n1+n2;
    }
    public int add(int n1,int n2, int n3){
        return n1+n2+n3;
    }
}
// using InheritanceDemo1;
// AdditionOp ad1=new AdditionOp();
// Console.WriteLine(ad1.add());
// Console.WriteLine(ad1.add(10,20));
// Console.WriteLine(ad1.add(10.5f,10.6f));
// Console.WriteLine(ad1.add(1,2,3));
// ContractEmp c=new ContractEmp();
// c.salaryCal();
// class Employee{
//     public virtual void salaryCal(){
//         Console.WriteLine("this is base class method");
//     }
// }
// class ContractEmp:Employee{
//     public override void salaryCal(){
//         base.salaryCal();
//         Console.WriteLine("This is derived class method");
//     }
// }

// Addition add1= new Addition();
// add1.getValues();
// add1.sum();
// class Arithmatic{           //Base Class
//     protected int n1,n2,result;//this variables only access only authorized class
//     public void getValues(){
//         Console.WriteLine("Enter number 1");
//         n1=Convert.ToInt16(Console.ReadLine());
//         Console.WriteLine("Enter number 2");
//         n2=Convert.ToInt16(Console.ReadLine());
//     }
// }
// //add is a arithmatic 
// class Addition:Arithmatic{      // child class
//     public void sum(){
//         result = n1+n2;
//         Console.WriteLine("Result "+result);
//     }
// }

// class Employee{
//     int empid; string name,des;
//     public void GetEmployeeDetails(){
//     }
//     public void ShowEmployeeDetails(){
//     }
// }
// class PermenanteEmployee:Employee{
//     double salary; double experience;
//     public void show(){
//     }
// }
// class contractEmployee:Employee{
//     double salary; double experience;
//     public void show(){
//     }
// }
// class Developer:PermenanteEmployee{
// }
