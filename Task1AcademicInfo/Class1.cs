namespace Task1AcademicInfo;


//question 6 and 8
public class AcademicInfo
{
    int studentid;
    string?[] subjectsarr=new string[5];
    int[] marks=new int[5];

    public int StudentId {get{return studentid;}set{studentid=value;}}
    public string[] SubjectName {get{return subjectsarr;}set {subjectsarr=value;}}
    public int[] Marks {get{return marks;}set{marks=value;}}
    public void GetAcademicDetails(){
        Console.WriteLine("Enter Student Id");
        StudentId=Convert.ToInt16(Console.ReadLine());
        for(int i=0; i<5; i++){
            Console.WriteLine("Enter Subject Name "+ (i+1));
            SubjectName[i]=Console.ReadLine();
            Console.WriteLine("Enter Marks "+(i+1));
            Marks[i]=Convert.ToInt16(Console.ReadLine());
        }
    }
    public int CalculatePercentage(){
        int sum=0;
        for(int i=0; i<5; i++){
            sum+=Marks[i];
        }
        int percentage=sum/5;
        return percentage;
    }
    public void ShowAcademicDetails(){
        Console.WriteLine("Student Id "+StudentId);
        for(int i=0; i<5; i++){
            Console.WriteLine("Subject Name "+SubjectName[i]);
            Console.WriteLine("Marks "+Marks[i]);
        }
        Console.WriteLine("Percentage "+CalculatePercentage());
    }
}
