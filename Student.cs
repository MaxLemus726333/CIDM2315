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