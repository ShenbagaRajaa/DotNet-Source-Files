using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics.Contracts;

Student student = new Student();
student.GetStudentMarks();
student.ShowStudentMarks();

public interface IStudent
{
    public void GetStudentMarks();
    public double CalculatePercentage();
    public void ShowStudentMarks();
}
public class Student : IStudent
{
    public int StudentId { get; set; }
    public string? StudentName { get; set; }
    public double Mark1 { get; set; }
    public double Mark2 { get; set; }
    public double Mark3 { get; set; }
    public double Percentage { get; set; }
    private static string connectionstr = "server=3.7.198.191;port=8993;user=bu-trausr;password=r9*rwr$!usFw0MCPj#fJ;database=bu-training;";
    static MySqlConnection con = new MySqlConnection(connectionstr);
    MySqlCommand cmd = con.CreateCommand();
    public void GetStudentMarks()
    {
        Console.WriteLine("Enter Student id");
        StudentId = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter Student name");
        StudentName = Console.ReadLine();
        Console.WriteLine("Enter Mark1");
        Mark1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Mark2");
        Mark2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Mark3");
        Mark3 = Convert.ToDouble(Console.ReadLine());
        Percentage = CalculatePercentage();
        con.Open();
        cmd.CommandType = CommandType.Text;
        string insertq = "insert into StudentAsShenba values (@StudentId,@StudentName,@Mark1,@Mark2,@Mark3,@Percentage)";
        cmd.CommandText = insertq;
        cmd.Parameters.AddWithValue("@StudentId", StudentId);
        cmd.Parameters.AddWithValue("@StudentName", StudentName);
        cmd.Parameters.AddWithValue("@Mark1", Mark1);
        cmd.Parameters.AddWithValue("@Mark2", Mark3);
        cmd.Parameters.AddWithValue("@Mark3", Mark3);
        cmd.Parameters.AddWithValue("@Percentage", CalculatePercentage());
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public double CalculatePercentage()
    {
        return (Mark1 + Mark2 + Mark3) / 3;
    }
    public void ShowStudentMarks()
    {
        con.Open();
        cmd.CommandText = "select * from StudentAsShenba order by Percentage desc";
        MySqlDataReader reads = cmd.ExecuteReader();
        if (reads.HasRows)
        {
            while (reads.Read())
            {
                Console.WriteLine(reads.GetInt16(0) + " " + reads.GetString(1) + " " + reads.GetDouble(5));
            }
        }
        else
        {
            Console.WriteLine("Table doesn't have rows");
        }
        reads.Close();
        con.Close();
    }
}