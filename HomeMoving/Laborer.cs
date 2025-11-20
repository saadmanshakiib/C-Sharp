namespace practice1;

public class Laborer : Employee
{
    public Laborer(){}

    public Laborer(int id,string name,string address,double userRating,double chargePerService,int noOfServices) 
        : base (id,name,address)
    {
        this.userRating = userRating;
        this.chargePerService = chargePerService; 
        this.noOfServices = noOfServices;
    }
    protected double userRating;
    protected double chargePerService = 500;
    protected int noOfServices;

    public void showLaborerInfo()
    {
        Console.WriteLine("Showing Laborer Info : ");
        ShowInfo();
        Console.WriteLine("User Rating: " + userRating);
        Console.WriteLine("Charge Per Service: " + chargePerService);
        Console.WriteLine("No of Services: " + noOfServices);
        Console.WriteLine();
    }

    public override bool EmployeeStatus()
    {
        return (userRating > 70 && noOfServices >=10)? true : false;
    }
}