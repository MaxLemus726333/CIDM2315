namespace MultiHomework;

class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer();
        c1.cus_name = "Alice";
        c1.SetId(110);
        c1.cus_age = 28;
        c1.PrintCustInfo();
        
        Customer c2 = new Customer();
        c2.cus_name = "Bob";
        c2.SetId(111);
        c2.cus_age = 30;
        c2.PrintCustInfo();

        c1.ChangeId(220);
        c2.ChangeId(221);

        // c1.CompareAge();
    }
}
     // Customer Section

class Customer{

    private int cus_id{get;set;}

    public string cus_name{get;set;} 

    public int cus_age{get;set;}

    public void PrintCustInfo(){
        Console.WriteLine($"Customer: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }

    public void ChangeId(int new_id){
        Console.WriteLine($"Customer: {new_id}, Name {cus_name}, Age: {cus_age}");
    }


    public void SetId(int plant){
        plant = cus_id;
    }

    public int GetId(){
        return cus_id;
    }

    // public void CompareAge(Customer objCustomer){
    //     if(this.cus_age <= objCustomer.cus_age){
    //         Console.WriteLine($"{cus_name} is older");
    //     }else{
    //         Console.WriteLine($"{objCustomer.cus_name} is older");
    //     }
}