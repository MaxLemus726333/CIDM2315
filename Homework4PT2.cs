namespace Homework;

class Program
{
    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.WriteLine("Enter an interger: "));
        
        string shape = Console.WriteLine("Right or Left: ");
        Console.ReadLine();
    }
    static void QuestionTwo(int N, string shape){
        if(shape == "Right"){
            for(int i=1; i<=N; i++){
                for(int j=1; j<=N; j++){
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        else{
            for(int i=1; i<=N; i++){
                for(int j=1; j<=N; j++){
                    Console.WriteLine("*");
                }
                Console.Write("");
            }
        }
    }
}