using practice1;

public class Program
{
    public static void Main(string[] sadman)
    {
        Manager sakib = new Manager(53647,"Sadman","Dhaka",5);
        sakib.showManagerInfo();
        Laborer janina = new Laborer(534123, "Janina", "BD", 3.5, 494.78, 6);
        janina.showLaborerInfo();
    }
}