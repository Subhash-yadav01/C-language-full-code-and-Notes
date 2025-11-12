using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.StatementsExpressionAndOperators.Operators
{
    internal class p2LogicalAndOrOperators
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 20;

            bool reslult = a > b && b < a;
            Console.WriteLine("Logical AND Operator (&&) Result: " + reslult);
            reslult = a < b || b > a;
            Console.WriteLine("Logical OR Operator (||) Result: " + reslult);


        }
    }
}
