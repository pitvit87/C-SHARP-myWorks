using System;
using static System.Console;
using static System.Convert;
using System.Collections;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Math.Sqrt(7);
            int a = 23903;
            string s;

            s = String.Format("x = {0:f3}", x);
            WriteLine(s);

            s = String.Format($"{a,15}");
            WriteLine(s);

            s = String.Format("{0:c}", a);
            WriteLine(s);

            s = String.Format("a(16) = {0,10}", a);
            WriteLine(s); 

            s = String.Format("a(16) = {0,10:x}", a);
            WriteLine(s);

            //x = 1.0e-9;
            x = 1000000000;
            s = String.Format("x = {0:e2}", x);
            WriteLine(s);


            ReadKey();
        }
    }
}
