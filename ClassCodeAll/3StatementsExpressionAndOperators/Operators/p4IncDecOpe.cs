using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.StatementsExpressionAndOperators.Operators
{
    internal class p4IncDecOpe
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("Initial value of a: " + a++);  // Post-increment
            Console.WriteLine("Value of a after post-increment: " + a);  // a is now 11

            Console.WriteLine("Value of a after pre-increment: " + ++a); // Pre-increment
            Console.WriteLine("Value of a after pre-increment: " + a);  // a is now 12

            Console.WriteLine("Value of a after pre-decrement: " + a--); // Post-decrement
            Console.WriteLine("Value of a after post-decrement: " + a);  // a is now 11

            Console.WriteLine("Value of a after pre-decrement: " + --a); // Pre-decrement
            Console.WriteLine("Value of a after pre-decrement: " + a);   // a is now 10







        }
    }
}
