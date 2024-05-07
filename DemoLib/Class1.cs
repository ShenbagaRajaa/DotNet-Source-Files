namespace DemoLib;

public class Class1
{
    int empid;
    string empname;

    // public Class1(int empid, string empname){
    //     this.empid=empid;
    //     this.empname=empname;
    // }
    public int id{
        get {return empid;}
        set {empid = value;}
    }
    public string name{
        get {return empname;}
        set {empname = value;}
    }
    
}
