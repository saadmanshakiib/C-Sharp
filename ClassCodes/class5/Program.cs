public class Program
{
    public static void Main(string[] sadman){
        // float[] a = new float[5];
        // Console.WriteLine("Enter Values : ");
        // for (int i = 0; i < 5; i++)
        // {
        //     string n = Console.ReadLine();
        //     a[i] = float.Parse(n);
        // }
        //
        // for (int i = 0; i < 5; i++)
        // {
        //     Console.WriteLine("Array : " + a[i]);
        // }

        // float[,] b = new float[3, 4];
        // b[0, 0] = 2;
        // b[0, 1] = 3;
        // b[0, 2] = 4;
        // b[0, 3] = 5;
        // b[1, 0] = 6;
        // b[1, 1] = 7;
        // b[1, 2] = 8;
        // b[1, 3] = 9;
        // b[2, 0] = 10;
        // b[2, 1] = 11;
        // b[2, 2] = 12;
        // b[2, 3] = 13;
        //
        // for (int i = 0; i < 3; i++)
        // {
        //     for (int j = 0; j < 4; j++)
        //     {
        //         Console.Write(b[i, j]+" ");
        //     }
        //     Console.WriteLine();
        // }
        // Console.WriteLine(23%2 == 0 ? "Even" : "Odd" );
        // Console.WriteLine();
        
        // for (int i = 0; i < 6; i++)
        // {
        //     Console.Write( i%2 == 0 ? "X" : "O");
        // }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write( i%2 == 1 ? "X" : "O");
            }
            Console.WriteLine();
        }
    }
}