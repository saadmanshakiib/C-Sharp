namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Student sadman = new Student();
            sadman.name = "Sakib";
            sadman.id = 53467;
            sadman.cg = 3.5;
            sadman.print();
                //// inheritence

                Employee sakib = new Employee();
                sakib.setName("Saadman Sakib");
                sakib.setSalary(50000);
                sakib.setAge(23);
                sakib.printEmployee();
                
                Console.WriteLine(Sum.add(34,34));
                Console.WriteLine(Sum.add(34,34,22));


        }
    }
}
