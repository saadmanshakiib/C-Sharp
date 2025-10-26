using System;

namespace class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //   //basic data types
          //   int i;
          //   float f = 0.5f;
          //   string s = "Saadman";
          //   char c = 's';
          //   double pi = 3.1416;
          //   bool check = false;
          //   i = 53467;
          //   long phone = 01615828990;
          //   
          //   Console.WriteLine(i);
          //   Console.WriteLine(phone);
          //   Console.WriteLine(pi); 
          //   Console.WriteLine(f);
          //   Console.WriteLine(c);
          //   Console.WriteLine(check);
          //   Console.WriteLine(phone);
          //
          //   //arithmatic operations
          //   int m = 34 + 43;
          //   int m2 = 4 * 6;
          //   int m3 = 12 / 4;
          //   int m4 = 88 - 65;
          //   Console.WriteLine(m);
          //   Console.WriteLine(m2);
          //   Console.WriteLine(m3);
          //   Console.WriteLine(m4);
          //   
          //   //string
          //   string fname = "Saadman";
          //   string lname = "Sakib";
          //   Console.WriteLine(fname +" "+lname);//concat
          //
          //   //i++;
          //   Console.WriteLine(i++);
          //   Console.WriteLine(++i);
          //   
          //   //input
          // // int input =   Console.Read();// ASCII Value
          //   //Console.ReadLine();
          //   // Console.WriteLine(input);
          //   // Console.WriteLine("Enter Your Name : ");
          //   // string name = Console.ReadLine()!;
          //   // Console.WriteLine(name);
          //   Console.WriteLine("Enter num 1 : ");
          //   string num1 = Console.ReadLine();
          //   Console.WriteLine("Enter num 2 : ");
          //   string num2 = Console.ReadLine();
          //   Console.WriteLine("Result : "+ num1+num2);
          //   //type casting
          //   int n1 = int.Parse(num1);
          //   int n2 = int.Parse(num2);
          //   Console.WriteLine("Sum : " + n1+n2);
          //   int sum = n1 + n2;
          //   int sub = n1 - n2;
          //   Console.WriteLine("Substrcat : " + sub);
          //   Console.WriteLine("Sum : " + sum);

                //task1
                
                Console.WriteLine("Enter a Number : ");
                string number = Console.ReadLine();
                Console.WriteLine("Enter another Number : ");
                string number2 = Console.ReadLine();
                //type casting->
                int number3 = Convert.ToInt32(number);
                int number4 = Convert.ToInt32(number2);
                int add = number3 + number4;
                Console.WriteLine("Addition : " + add);
                int diff = number3 - number4;
                Console.WriteLine("Difference : " + diff);
                int mul =  number3 * number4;
                Console.WriteLine("Multiplication : " + mul);
                int div = number3 / number4;
                Console.WriteLine("Division : " + div);


        }
    }
};

