using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.DataTypes
{
    internal class p4DateAndTime
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            // Console.WriteLine("Current Date and Time: " + dt.ToString());
            // Console.WriteLine($"Current Date and Time: {dt}");
            Console.WriteLine("small d is show short date only: {0:d}",dt);
            Console.WriteLine("capital D is show long date only: {0:D}", dt);
            Console.WriteLine("small t is show short time only: {0:t}", dt);
            Console.WriteLine("capital T is show long time only: {0:T}", dt);
            Console.WriteLine("small f is show long date and short time: {0:f}", dt);
            Console.WriteLine("capital F is show long date and long time: {0:F}", dt);
            Console.WriteLine("small g is show general date and short time: {0:g}", dt);
            Console.WriteLine("capital G is show general date and long time: {0:G}", dt);
            Console.WriteLine("small M or m is show month and day: {0:M}", dt);
            Console.WriteLine("small Y or y is show year and month: {0:Y}", dt);

            Console.ReadLine();
        }
    }
}
