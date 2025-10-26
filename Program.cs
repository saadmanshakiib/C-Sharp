using System;

namespace class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //basic data types
            int i;
            float f = 0.5f;
            string s = "Saadman";
            char c = 's';
            double pi = 3.1416;
            bool check = false;
            i = 53467;
            long phone = 01615828990;
            
            Console.WriteLine(i);
            Console.WriteLine(phone);
            Console.WriteLine(pi); 
            Console.WriteLine(f);
            Console.WriteLine(c);
            Console.WriteLine(check);
            Console.WriteLine(phone);

            //arithmatic operations
            int m = 34 + 43;
            int m2 = 4 * 6;
            int m3 = 12 / 4;
            int m4 = 88 - 65;
            Console.WriteLine(m);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            
            //string
            string fname = "Saadman";
            string lname = "Sakib";
            Console.WriteLine(fname +" "+lname);//concat

            //i++;
            Console.WriteLine(i++);
            Console.WriteLine(++i);


        }
    }
};

