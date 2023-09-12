using System;
using System.Data.SqlTypes;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            decimal b;

            a = 1.0 / 3.0;
            b = (decimal)1.0 / (decimal)3.0;

            WriteLine("a = " + a);
            WriteLine("b = " + b);

            a = a * 3.0;
            b = b * (decimal)3.0;
            WriteLine("a = " + a);
            WriteLine("b = " + b);

            b = Decimal.Multiply(b, (decimal)5);
            WriteLine("b2 = " + b);
            b = Decimal.Divide(b, (decimal)4);
            WriteLine("b3 = " + b);

            ReadKey();
        }
    }
}
