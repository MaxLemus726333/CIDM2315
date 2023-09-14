namespace Homework;

class Program
{
    static void Main(string[] args)
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