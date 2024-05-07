namespace InheritanceDemo1;

class OperatorOverloading {
     
    public int number1 , number2;
    public OperatorOverloading(int num1 , int num2)
    {
        number1 = num1;
        number2 = num2;
    }
     
// Function to perform operation
// By changing sign of integers
public static OperatorOverloading operator -(OperatorOverloading c1)
{
    c1.number1 = -c1.number1;
    c1.number2 = -c1.number2;
    return c1;
}
 
// Function to print the numbers
public void Print()
{
    Console.WriteLine ("Number1 = " + number1);
    Console.WriteLine ("Number2 = " + number2);
}
}

// using InheritanceDemo1;
// ConstructorOverloading ad1=new ConstructorOverloading(20.2f,"helo");
// ad1.print();
// using InheritanceDemo1;
// OperatorOverloading calc = new OperatorOverloading(15, -25);
// calc = -calc;
// calc.Print();