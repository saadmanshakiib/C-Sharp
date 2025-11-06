public class Program
{
    public static void Main(string[] sadman){
        int[] a = new int[5];
        Console.WriteLine("Enter Values : ");
        for (int i = 0; i < 5; i++)
        {
            string n = Console.ReadLine();
            a[i] = int.Parse(n);
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Array : " + a[i]);
        }
    }
}