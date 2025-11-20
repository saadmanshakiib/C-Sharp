using System;

class ShortJagged
{
    static int ToInt(string s)
    {
        int r = 0;
        int sign = s[0] == '-' ? -1 : 1; 
        for (int i = sign == -1 ? 1 : 0; i < s.Length; i++) 
         
            r = r * 10 + (s[i] - '0');
        return r * sign;
        
    } 
    static void Create(out short[][] a, int rows) 
    { a = new short[rows][];
        for (int i = 0; i < rows; i++)
        {
            a[i] = new short[i + 2];
            for (int j = 0; j < a[i].Length; j++)
            {
                a[i][j] = (short)((i + 1) * (j + 1));
            }
        } }
    static void Analyze(short[] row, out short sum, out short max) 
    { sum = 0; max = short.MinValue;
        foreach (short n in row)
        {
            sum += n; if (n > max) max = n;
        }
        
    }

    static void Main()
    {
        Console.Write("Rows: ");
        int r = ToInt(Console.ReadLine());
        
        Create(out short[][] jag, r);
        
        Console.WriteLine("\nGenerated Array:"); 
        for (int i = 0; i < jag.Length; i++) 
            Console.WriteLine($"Row {i}: {string.Join(" ", jag[i])}"); 
        
        Console.Write("\nRow index: ");
        int ri = ToInt(Console.ReadLine());
        
        Console.Write("Col index: "); 
        int ci = ToInt(Console.ReadLine());
        
        Console.Write("New short value: ");
        short val = (short)ToInt(Console.ReadLine());
        ref short element = ref jag[ri][ci];
        
        element = val;
        
        Console.WriteLine("\nAnalysis:");
        for (int i = 0; i < jag.Length; i++)
        {
            Analyze(jag[i], out short sum, out short max); 
            Console.WriteLine($"Row {i}: Sum={sum}, Max={max}");
        } 
        Console.WriteLine("\nUpdated Array:"); 
        for (int i = 0; i < jag.Length; i++) 
            Console.WriteLine($"Row {i}: {string.Join(" ", jag[i])}");
    }
}