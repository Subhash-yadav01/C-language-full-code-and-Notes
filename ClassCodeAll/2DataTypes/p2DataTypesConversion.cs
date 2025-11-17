using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.DataTypes
{
    internal class p2DataTypesConversion
    {
        static void Main(string[] args)
        {
            int a = 20;
            float b = a; // Implicit Conversion
            Console.WriteLine("Implicit Conversion from int to float: " + b);

            float c = 9.78F;
            int d = (int)c; // Explicit Conversion
            int e = Convert.ToInt32(c); // Using Convert class
            Console.WriteLine("Explicit Conversion from float to int: " + d);
            Console.WriteLine("Conversion using Convert class from float to int: " + e);

            string strNumber = "1234";
            int f = int.Parse(strNumber); // Using Parse method
            Console.WriteLine("String to int conversion using Parse: " + f);

            string k = "50";
            string l = "25";
            int m = int.Parse(k);
            int n = int.Parse(l);
            int sum = m + n;
            Console.WriteLine("Sum of two string numbers after conversion: " + sum);

            string r = "10";
            string s = "20";
            int t = Convert.ToInt32(r) + Convert.ToInt32(s);
            Console.WriteLine("Sum of two string numbers using Convert class: " + t);

            Console.ReadLine();
        }
    }
}
