using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.StatementsExpressionAndOperators
{
    internal class p3AssignmentOpe
    {
        static void Main(string[] args)
        {
            int a = 5;
            a += 10; // a = a + 10
            Console.WriteLine("After += operator, a = " + a);

            a -= 3; // a = a - 3
            Console.WriteLine("After -= operator, a = " + a);

            a *= 2; // a = a * 2
            Console.WriteLine("After *= operator, a = " + a);

            a /= 4; // a = a / 4
            Console.WriteLine("After /= operator, a = " + a);
            
            a %= 3; // a = a % 3
            Console.WriteLine("After %= operator, a = " + a);

        }
    }
}
