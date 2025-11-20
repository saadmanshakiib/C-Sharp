public class Person
{
    protected string name;
    protected int age;
    
    public Person(){}

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void printPerson()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public void setAge(int age)
    {
        this.age = age;
    }
}