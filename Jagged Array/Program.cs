
public class Program
{
    static void Main(string[] sad)
    {
        int[][] ja = new int[4][];
        ja[0] = new int[] { 11, 23, 14, 56, 21, 33 };
        ja[1] = new int[] { 12, 45, 21, 6, 67 };
        ja[2] = new int[] { 88, 65, 21, 22 };
        ja[3] = new int[] { 312, 3231, 442, 11 };
        
        for (int row = 0; row < 4; row++)
        {
            Console.Write("Row : " + row + " = ");
            
            for (int elements = 0; elements < ja[row].Length; elements++)
            {
                Console.Write(ja[row][elements] + " ");
            }

            Console.WriteLine();

        }

// ja[3][2] ? 
//ja [0][3]

Console.WriteLine("JA[3][2] : " + ja[0][3] * 2 );






        int[][] ja2 = new int[][]
        {
            new int[] { 30, 31, 35, 34 },
            new int[] { 50, 51, 56 },
            new int[] { 10, 22 }
        };
        
        Console.WriteLine("print2 : ");
        for (int row = 0; row < ja2.Length; row++)
        {
            Console.Write("Row : "+ row+" = ");
            for (int index = 0; index < ja2[row].Length; index++)
            {
                Console.Write(ja2[row][index] + " ");
            }
            Console.WriteLine();
        }

        // print
    }
}