namespace InheritanceDemo1;

public class ConstructorOverloading
{
    int a; float b;  string c;
    public ConstructorOverloading(int i,float f,string s){
        a=i;
        b=f; c=s;
    }
    public ConstructorOverloading(string s, int i){
        c=s;
        a=i;
    }
    public ConstructorOverloading(float f, string s){
        b=f;
        c=s;
    }
    public void print(){
        Console.WriteLine(a+b+c);
    }
}
