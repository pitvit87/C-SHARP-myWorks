using System;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace Yevtukh_KolomiietsC_DZ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Write("Enter 'x':");
            x = ToDouble(ReadLine());

            Write("Enter 'y':");
            y = ToDouble(ReadLine());

            z = ((Math.Sin(x) + ((2 + y) / Math.Pow(x, 2)) / Math.Sqrt(Math.Abs(y) + 2)));

            WriteLine("x = {0:f4}", x);
            WriteLine("y = {0:f4}", y);
            WriteLine("z = {0:f6}", z);

            WriteLine("Apex of a triangle_1(x1):");
            double x1 = ToDouble(ReadLine());
            WriteLine("Apex of a triangle_1(y1):");
            double y1 = ToDouble(ReadLine());
            WriteLine("Apex of a triangle_2(x2):");
            double x2 = ToDouble(ReadLine());
            WriteLine("Apex of a triangle_2(y2):");
            double y2 = ToDouble(ReadLine());
            WriteLine("Apex of a triangle_3(x3):");
            double x3 = ToDouble(ReadLine());
            WriteLine("Apex of a triangle_3(y3):");
            double y3 = ToDouble(ReadLine());

            double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            WriteLine("a = " + a);
            double b = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            WriteLine("b = " + b);
            double c = Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2));
            WriteLine("c = " + c);

            double per = (a + b + c);
            double p = per / 2;
            WriteLine($"Perimetr rectangle = {per:f3}");

            double sum;
            double s1;
            sum = p * (p - a) * (p - b) * (p - c);
            s1 = Math.Sqrt(sum);
            //s2 = Math.Log(sum,2);

            WriteLine("Area rectangle "  + s1);
            //WriteLine("Area rectangle "  + s2);
            WriteLine($"Area rectangle = {s1:f3}");
            //WriteLine($"Area rectangle = {s2:f3}");


            ReadKey();
        }
    }
}
