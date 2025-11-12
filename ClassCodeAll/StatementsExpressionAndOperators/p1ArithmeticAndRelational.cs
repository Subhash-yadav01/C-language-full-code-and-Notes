using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.StatementsAndOperators
{
    internal class p1ArithmeticAndRelational
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, c, d, e, f, g;
            c = a + b;
            d = a - b;
            e = a * b;
            f = b / a;
            g = b % a;

            Console.WriteLine("Arithmetic Operators:\n");

            Console.WriteLine("a = " + a + "\n");
            Console.WriteLine("b = " + b + "\n");

            Console.WriteLine(c +"\n");

            Console.WriteLine(d + "\n");

            Console.WriteLine(e + "\n");

            Console.WriteLine(f + "\n");

            Console.WriteLine(g + "\n");

            Console.WriteLine("Relational Operators:\n");

            Console.WriteLine("a = " + a + "\n");
            Console.WriteLine("b = " + b + "\n");

            Console.WriteLine("a == b: " + (a == b) + "\n");

            Console.WriteLine("a != b: " + (a != b) + "\n");

            Console.WriteLine("a > b: " + (a > b) + "\n");

            Console.WriteLine("a < b: " + (a < b) + "\n");

            Console.WriteLine("a >= b: " + (a >= b) + "\n");

            Console.WriteLine("a <= b: " + (a <= b) + "\n");

            Console.ReadLine();







        }
    }
}
