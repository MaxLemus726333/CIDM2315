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