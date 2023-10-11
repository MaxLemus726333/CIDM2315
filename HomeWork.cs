namespace MultiHomework;

class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor();
        p1.Name = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        p1.PrintInfo();

        Professor p2 = new Professor();
        p2.Name = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);
        p2.PrintInfo();


        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.SetGrade(90);
        s1.PrintInfo();
        

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.SetGrade(80);
        s2.PrintInfo();

        p1.PrintmoneyDif();
        s1.PrintTGrade();
    }
}