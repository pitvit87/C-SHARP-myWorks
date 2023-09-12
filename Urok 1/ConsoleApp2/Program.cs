using System;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, x;

            Write("a = ");
            a = ToDouble(ReadLine());

            double t = 2 * a + Sin(Abs(3 * a));
            x = Sqrt(t / 3.56);

            WriteLine("x = " + x);
            ReadKey();
        }
    }
}
