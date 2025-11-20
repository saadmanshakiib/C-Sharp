public class Employee : Person
{
    private int salary;
    public Employee(){}

    public Employee(string name, int age, int salary)
        : base(name, age)
    {
        this.salary = salary;
    }

    public void printEmployee()
    {
        printPerson();
        Console.WriteLine("Salary: " + salary);
    }

    public void setSalary(int salary)
    {
        this.salary = salary;
    }
}