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

//     Professor Section
class Professor{
    public string Name {get;set;} = string.Empty;

    public string classTeach {get;set;} = string.Empty;

    private double salary{get;set;}

    public void PrintInfo(){
        Console.WriteLine($"Professor {Name} teaches {classTeach}, and the salary is: {salary}");

    }
    public void SetSalary(double salary_amount){
        salary = salary_amount;
    }

    public double GetSalary(){
        return salary;
    }

    int totalm = 9000 - 8000;
    public int moneyDif(){
        return totalm;
    }

    public void PrintmoneyDif(){
        Console.WriteLine($"The Difference The difference between Alice and Bob salary is: {totalm}");
    }
}

//    Student section
class Student{
    public string studentName;

    public string classEnroll;

    private double studentGrade{get;set;}

    public void PrintInfo(){
        Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is: {studentGrade}");
    }

    public void SetGrade(double newGrade){
        studentGrade = newGrade;
    }

    public double GetGrade(){
        return studentGrade;
    }

    int total = 90 + 80;
    public int totalGrade(){
        return total;
    }

    public void PrintTGrade(){
        Console.WriteLine($"The total grade of Lisa and Tom is: {total}");
    }

}