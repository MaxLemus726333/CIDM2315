namespace Homework;

class Program
{

    static void Main (string[] args)
    {
        Console.WriteLine("Input the first number: ");
        string a = Console.ReadLine();
        int int_a = Convert.ToInt16(a);

        Console.WriteLine("Input a second number: ");
        string b = Console.ReadLine();
        int int_b = Convert.ToInt16(b);
        
        int largest = QuestionOne(int_a, int_b);
        Console.WriteLine($"A = {a}, B = {b}");
        Console.WriteLine($"The largest number is: {largest}");
    }
    static int QuestionOne(int a, int b){
        if(a>b){
            return a;
        }
        else{
            return b;
        }
    }


}
    // End of question One

    // Question Two
{
    Console.WriteLine("Input the first number: ");
        string a = Console.ReadLine();
        int int_a = Convert.ToInt16(a);

        Console.WriteLine("Input a second number: ");
        string b = Console.ReadLine();
        int int_b = Convert.ToInt16(b);

        Console.WriteLine("Input the third number: ");
        string c = Console.ReadLine();
        int int_c = Convert.ToInt16(c);

        Console.WriteLine("Input a fourth number: ");
        string d = Console.ReadLine();
        int int_d = Convert.ToInt16(d);
        
        int largest = QuestionTwo(int_a, int_b, int_c, int_d);
        Console.WriteLine($"A = {a}, B = {b}, C = {c}, D = {d}");
        Console.WriteLine($"The largest number is: {largest}");

static int QuestionTwo(int a, int b, int c, int d){
        if(a>b){
            if(a>b){
                return a;
            }
            else{
                return b;
            }
        }
        else if(c>d){
            if(c>d){
                return c;
            }
            else{
                return d;
            }
        }
        else{
            if(b>d){
                return b;
            }
            else{
                return d;
            }
        }
    }
}
    // End of question two

    // Question Three
    {
        int birth_year = 2023-1999;
        string username = "Alice";
        string password = "Alice";
        string re_password = "Alice";

        createAccount();
        checkAge(birth_year:birth_year, password:password, re_password:re_password);
        
    }
    static bool checkAge(int birth_year, string password, string re_password){
        int age = 2023-birth_year;
        if(age>=18){
            Console.WriteLine("Account is created successfully");
                if(password == "Alice"){
                    Console.WriteLine("");
                }
                else{
                    Console.WriteLine("Wrong password");
                }
                    if(re_password == "Alice"){
                        Console.WriteLine("");
                    }
                    else{
                    Console.WriteLine("Wrong password");
                    }
                return true;
        }
        else{
            Console.WriteLine("Could not create an account");
            return false;
        }
    }
    static void createAccount(){
        Console.WriteLine("Enter username: ");
        string username = Console.ReadLine();

        Console.WriteLine("Enter password: ");
        string password = Console.ReadLine();

        Console.WriteLine("Re-Enter password: ");
        string re_password = Console.ReadLine();

        Console.WriteLine("Enter birth year: ");
        int birthyear = Convert.ToInt16(Console.ReadLine());
    }