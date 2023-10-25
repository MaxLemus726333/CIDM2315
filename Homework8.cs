namespace Homework;


class Program
{

    public static void Main (string[] args)
    {
        //test Q1
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);

        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        //Test Q2-1
        PrintAllOddNumbers(array_2d);

        //Test Q2-2
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");
        
        // //Test Q2-3
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("This new 2d array: ");
        foreach(int num in Q2_3){
            Console.Write(num +  num + " ");
        }
    }

    //Q1: Calculate the sum of elements
    public static void ArraySum(int[] int_array){
        Console.WriteLine($"The Sum of int_array is: {int_array.Sum()}");
    }

    //Q2-1: Gevin a 2d array, print all odd numbers
    public static void PrintAllOddNumbers(int[,] array_2d){
        foreach(int val in array_2d){
            if(val%2!=0){
            Console.Write(val + " ");
            }
        }
    }

    //Q2-2: Given a 2d array, return total sum
    public static int ElementSum(int[,] array_2d){
        int total = 0;
        for(int i= 0; i < array_2d.GetLength(0); i++){
            for(int j = 0; j < array_2d.GetLength(1); j++){
                total += array_2d[i,j];
            }
        }
        return total;
    }

    // //Q3: Given a 2d array, double its element values and return
    public static int[,] DoubleArray(int[,] array_2d){
        int[,] Q2_3 = array_2d;
            return array_2d;
    }
}