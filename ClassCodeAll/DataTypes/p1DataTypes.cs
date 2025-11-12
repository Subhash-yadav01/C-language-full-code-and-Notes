using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.DataTypes
{
    internal class p1DataTypes
    {
        static void Main(string[] args)
        {
            /* Data Types in C#
             how to know the size of each data types
                        MaxValue
                        MinValue
            */
            Console.WriteLine("The integer MaxVlue is : " + int.MaxValue);
            Console.WriteLine("The integer MinValue is: " + int.MinValue);

            // -----------integer data type-------------

            Console.WriteLine("\n----------------Integer Data Types-------------------\n");
            byte b = 255; // 1 byte
            Console.WriteLine("Byte value: " + b);
            Console.WriteLine("The byte MaxVlue is : " + byte.MaxValue);
            Console.WriteLine("The byte MinValue is: " + byte.MinValue);

            short s = 32767; // 2 bytes
            Console.WriteLine("\nShort value: " + s);
            Console.WriteLine("The short MaxVlue is : " + short.MaxValue);
            Console.WriteLine("The short MinValue is: " + short.MinValue);

            int i = 2147483647; // 4 bytes
            Console.WriteLine("\nInteger value: " + i);
            Console.WriteLine("The integer MaxVlue is : " + int.MaxValue);
            Console.WriteLine("The integer MinValue is: " + int.MinValue);

            long l = 9223372036854775807; // 8 bytes
            Console.WriteLine("\nLong value: " + l);
            Console.WriteLine("The long MaxVlue is : " + long.MaxValue);
            Console.WriteLine("The long MinValue is: " + long.MinValue);

            sbyte sb = -128; // 1 byte  
            Console.WriteLine("\nSByte value: " + sb);
            Console.WriteLine("The sbyte MaxVlue is : " + sbyte.MaxValue);
            Console.WriteLine("The sbyte MinValue is: " + sbyte.MinValue);

            ushort us = 65535; // 2 bytes
            Console.WriteLine("\nUShort value: " + us);
            Console.WriteLine("The ushort MaxVlue is : " + ushort.MaxValue);
            Console.WriteLine("The ushort MinValue is: " + ushort.MinValue);

            uint ui = 4294967295; // 4 bytes
            Console.WriteLine("\nUInt value: " + ui);
            Console.WriteLine("The uint MaxVlue is : " + uint.MaxValue);
            Console.WriteLine("The uint MinValue is: " + uint.MinValue);

            ulong ul = 18446744073709551615; // 8 bytes
            Console.WriteLine("\nULong value: " + ul);
            Console.WriteLine("The ulong MaxVlue is : " + ulong.MaxValue);
            Console.WriteLine("The ulong MinValue is: " + ulong.MinValue);

            // -----------decimal point data type-------------

            Console.WriteLine("\n----------------Decimal Data Types-------------------\n");

            float f = 3.40282347E+38F; // 4 bytes
            Console.WriteLine("Float value: " + f);
            Console.WriteLine("The float MaxVlue is : " + float.MaxValue);
            Console.WriteLine("The float MinValue is: " + float.MinValue);

            double d = 2.79769313632308; // 8 bytes
            Console.WriteLine("\nDouble value: " + d);
            Console.WriteLine("The double MaxVlue is : " + double.MaxValue);
            Console.WriteLine("The double MinValue is: " + double.MinValue);

            decimal dec = 79228162514264337593543950335M; // 16 bytes
            Console.WriteLine("\nDecimal value: " + dec);
            Console.WriteLine("The decimal MaxVlue is : " + decimal.MaxValue);
            Console.WriteLine("The decimal MinValue is: " + decimal.MinValue);

            // -----------other data type-------------
            Console.WriteLine("\n----------------Other Data Types-------------------\n");
            char c = 'A'; // 2 bytes
            Console.WriteLine("Char value: " + c);
            Console.WriteLine("The char MaxVlue is : " + char.MaxValue);
            Console.WriteLine("The char MinValue is: " + char.MinValue);

            bool bo = true; // 1 bit
            Console.WriteLine("\nBoolean value: " + bo);
            Console.WriteLine("The bool MaxVlue is : " + bool.TrueString);
            Console.WriteLine("The bool MinValue is: " + bool.FalseString);

            string str = "Hello, World!"; // size varies
            Console.WriteLine("\nString value: " + str);
            Console.WriteLine("The string MaxVlue is : " + int.MaxValue + " characters (theoretical limit)");
            Console.WriteLine("The string MinValue is: " + 0 + " characters");

            DateTime dt = DateTime.Now; // 8 bytes
            Console.WriteLine("\nDateTime value: " + dt);
            Console.WriteLine("The DateTime MaxVlue is : " + DateTime.MaxValue);
            Console.WriteLine("The DateTime MinValue is: " + DateTime.MinValue);

            Guid guid = Guid.NewGuid(); // 16 bytes
            Console.WriteLine("\nGuid value: " + guid);
            Console.WriteLine("The Guid MaxVlue is : " + Guid.Empty);
            Console.WriteLine("The Guid MinValue is: " + Guid.Empty);

            object obj = new object(); // size varies
            Console.WriteLine("\nObject value: " + obj);
            Console.WriteLine("The object MaxVlue is : " + "Varies based on the actual object");
            Console.WriteLine("The object MinValue is: " + "Varies based on the actual object");

            Console.ReadLine();

        }
    }
}
