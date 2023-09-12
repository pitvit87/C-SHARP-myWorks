using System;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float f = (float)Math.Sin(10);
            double x = Math.Log(10);

            WriteLine("f = " + f);
            WriteLine("x = " + x);

            WriteLine("f = {0:f3}", f);
            WriteLine("x = {0:f2}", x);

            WriteLine($"f = {f:f3}");
            WriteLine($"x = {x:f4}");

            WriteLine("f = {0:f5}, x = {1:f2}, (f+x) = {2:f3}", f, x, f + x);

            ReadKey();
        }
    }
}
