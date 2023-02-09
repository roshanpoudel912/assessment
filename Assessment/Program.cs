namespace Assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentM = new StudentManager();
            studentM.AddStudent(new Student() { Id = 1,Name="Roshan Poudel", Age = 29, grades = new List<double>() { 3D,4D,5D } });
            studentM.AddStudent(new Student() { Id = 2,Name="Hemant Chauhan", Age = 30, grades = new List<double>() { 6D,7D,8D } });
            studentM.AddStudent(new Student() { Id = 3,Name="Rakesh Jaiswal", Age = 31, grades = new List<double>() { 9D,10D,11D } });
            studentM.AddStudent(new Student() { Id = 4,Name="Allen Levsen", Age = 32, grades = new List<double>() { 12D,13D,14D } });
            studentM.AddStudent(new Student() { Id = 5,Name="Inderjeet Singh", Age = 33, grades = new List<double>() { 15D,16D,17D } });

            studentM.RemoveStudent(6);
            studentM.DisplayStudents();
        }
    }
}