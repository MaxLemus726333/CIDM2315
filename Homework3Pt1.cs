namespace Homework;

class Program
{
    static void Main(string[] args)
    {
        int N = 0;
        Console.WriteLine("Input an interger: ");
        Console.ReadLine();

        while(N%2==0)
        {
            Console.WriteLine("N is prime");
            break;
        }
        Console.WriteLine("N is non-prime");

    }
}