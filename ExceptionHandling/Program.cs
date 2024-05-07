


// Delwelcommessage objdelwelcomemessage = new Delwelcommessage(WelcomeMessage);
// Student.AddStudentName(" Navin", objdelwelcomemessage);

// void WelcomeMessage()
// {
//     Console.WriteLine("Welcome All");
// }
// public delegate void Delwelcommessage();
// public class Student
// {
//     public string? Name { get; set; }
//     public static void AddStudentName(string Name, Delwelcommessage MsgCallback)
//     {
//         Console.WriteLine("Added Data Successfully ");
//         MsgCallback();
//     }
// }


// Addition ad=new Addition();   
// ad.MyStartEvent+=Displaymsg; 
// ad.MyEndEvent+=Showmsg;    
// ad.MyLiveCommentry+=Livecommentry;                                 
// ad.DoCalculation();                                     
// void Displaymsg(){
//     Console.WriteLine("Your process is started now");
// }
// void Showmsg(){                                           
//     Console.WriteLine("Your process is done");
// }
// void Livecommentry(object sender,int val){
//     Console.WriteLine(val+"% completed");
// }
// public delegate void MyNotification();
// class Addition{
//     public event MyNotification MyStartEvent;    
//     public event EventHandler<int> MyLiveCommentry;                                                  
//     public event MyNotification MyEndEvent;             
//     public void DoCalculation(){   
//         OnmyStartevent(); 
//         int sum=0;
//         for(int i=0; i<10000; i++){
//             sum+=i; 
//             if(i%25==0){

//             }
//         }
//         Console.WriteLine(sum);
//         OnmyEndevent();
//         // MyEvent.Invoke();
//     }
//     protected virtual void OnmyLiveComint(int val){
//         MyLiveCommentry.Invoke(this.val);
//     }
//     protected virtual void OnmyStartevent(){
//         MyStartEvent.Invoke();
//     }
//     protected virtual void OnmyEndevent(){
//         MyEndEvent.Invoke();
//     }
// }


//theading
Addition obj= new Addition();
Thread thr1= new Thread(()=>obj.Add());
Thread thr2= new Thread(new ThreadStart(obj.Protuct));  //unrunnable state
Thread thr3= new Thread(new ThreadStart(obj.Protuct));
// thr1.Start();   
// thr2.Start();
// thr2.Join();
// thr3.Start(); 
thr1.Name="hello";
thr1.Priority=ThreadPriority.Highest;
Console.WriteLine(thr1.Name+" "+thr1.Priority);     
thr2.Name="hellooooooo";
thr2.Priority=ThreadPriority.Lowest;   
Console.WriteLine(thr2.Name+" "+thr2.Priority);                        //runnabel State
class Addition{
    public void Add(){                      //Running State
        int sum=0;
        for(int i=1; i<=5; i++){
            Console.WriteLine(i);
            sum+=i;
            Thread.Sleep(3000);
        }
        Console.WriteLine(sum);
    }   public void Protuct(){                      //Running State
        int sum=1;
        for(int i=1; i<=5; i++){
            Console.WriteLine(i);
            sum*=i;
            Thread.Sleep(3000);
        }
        Console.WriteLine(sum);
    }
}
































// Addition ad=new Addition();                                         //through busoft
// ad.DoCalculation(Callback);                                     //through busoft get project

// void Callback(int i){                                            //communication details excelsheet, ppt report
//     Console.WriteLine(i);
// }
// class Addition{                                                     //busoft
//     public delegate void Callback(int x);                        //Project explain representative
//     public void DoCalculation(Callback delegateobjcallback){    //long running process //It is my project
//         int sum=0;
//         for(int i=0; i<10000; i++){
//             sum+=i;             //Some process
//             delegateobjcallback(i);
//         }
//         Console.WriteLine(sum);
//     }
// }

// Addition ad=new Addition();
// ad.Add(10,30,call);
// ad.Diff(20,10,call);
// void call(int i){
//     Console.WriteLine(i);
// }

// class Addition{
//     public delegate void Arthmaticdele(int x);
//     public void Add(int n1, int n2, Arthmaticdele adobj){
//         adobj(n1+n2);
//         Console.WriteLine(n1+n2);
//     }
//     public void Diff(int n1, int n2,Arthmaticdele adobj){
//         adobj(n1-n2);
//         Console.WriteLine(n1-n2);
//     }
// }

// using System.Reflection;

// Addition ad=new Addition();
// Arthmaticdele adde=new Arthmaticdele(ad.Add);
// // adde(1,2);
// Arthmaticdele adde1=new Arthmaticdele(ad.Diff);
// // adde1(1,2);
// Arthmaticdele muldele= adde+adde1;
// muldele -= adde1;
// muldele.Invoke(1,2);

// Delegate[] Invocatonlist = muldele.GetInvocationList();
// foreach(var i in Invocatonlist){
//     // Console.WriteLine(i.GetHashCode());
//     Console.WriteLine(i.GetMethodInfo());
//     //  Console.WriteLine(i.GetType());
//     //   Console.WriteLine(i.Equals(i));
//     // //    Console.WriteLine(i.DynamicInvoke());
//     //    Console.WriteLine(i.ToString());
//     //    Console.WriteLine(i.Method.GetBaseDefinition());
//     //    Console.WriteLine(i.Target.GetType());
// }
// public delegate void Arthmaticdele(int x,int y);
// class Addition{

//     public void Add(int n1, int n2){
//         Console.WriteLine(n1+n2);
//     }
//     public void Diff(int n1, int n2){
//         Console.WriteLine(n1-n2);
//     }
// }