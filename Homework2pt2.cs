namespace Homework;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first num: ");
            int num_1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the second num: ");
            int num_2 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the third num: ");
            int num_3 = Convert.ToInt16(Console.ReadLine());
        
        if(num_1 < num_2 && num_2 < num_3){
            int min = (num_1);
        }
        else if(num_2 < num_3 && num_3 < num_1){
            int min = (num_2);
        }
        else{//num_3 < num_1 && num_3 < num_2
        
            int min = (num_3);
        }

        Console.WriteLine($"The smallest value is: "+Math.Min(num_1, Math.Min(num_2, num_3)));
    }

}
