namespace practice1;

public class Employee
{
    public Employee(){}

    public Employee(int id, string name, string address)
    {
        this.id = id;
        this.name = name;
        this.address = address; 
    }
    protected  int id;
    protected  string name;
    protected  string address;

    public void ShowInfo()
    {
        Console.WriteLine("Name : "+name);
        Console.WriteLine("ID : "+id);
        Console.WriteLine("Address : "+address);

    }

    public virtual bool EmployeeStatus()
    {
        return false;
    }

}