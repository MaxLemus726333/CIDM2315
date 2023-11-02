namespace MultiHomework;

class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");
        

        Dictionary<double, string> gradebook = new Dictionary<double, string>();
        gradebook.Add(4.0, "Alice");
        gradebook.Add(3.6, "Bob");
        gradebook.Add(2.5, "Cathy");
        gradebook.Add(1.8, "David");

//Starting Output
        Console.WriteLine("Checking if Tom is here.");
        if(gradebook.ContainsKey(3.3)==true){
            Console.WriteLine("Tom is here");
        }
        else{
            Console.WriteLine("Adding Tom to gradebook");
        }
        gradebook.Add(3.3, "Tom");


// Getting Average
        double total = 4.0+3.6+2.5+1.8+3.3;
        double average = total/5;
        Console.WriteLine($"The average GPA is: {average}");
        
        foreach(var stu in Student.student_list){
                stu.PrintInfo();
            }
        }
    }
    // Student Class
    class Student{

    public static List<Student> student_list = new List<Student>();
    private int studentID {get; set;}

    private string studentName {get; set;}

    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
    
    public Student(int inputID, string inputName){
        studentID = inputID;
        studentName = inputName;
        student_list.Add(this);
    }
}
