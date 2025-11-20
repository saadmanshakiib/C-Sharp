namespace practice1;

public class Manager : Employee
{
    private int yearsOfExperience;
    public Manager(){}
    

    public Manager(int id, string name, string address, int yearsOfExperience)
    : base(id,name,address)
    {
        this.yearsOfExperience = yearsOfExperience;
    }

    public void showManagerInfo()
    {
        Console.WriteLine("Showing Manager Info : ");
        ShowInfo();
        Console.WriteLine("Years of Experience: " + yearsOfExperience);
        Console.WriteLine();
    }

    public override bool EmployeeStatus()
    {
        Console.Write("Employee Status : ");
        return (yearsOfExperience > 2)? true : false;
    }
}