using System;
using static System.Console;
using static System.Convert;

namespace ConsoleApp1
{
    class ProcessFigures
    {

        public double Length(double r)
        {
            return 2 * Math.PI * r;
        }

        public double Area(double r)
        {
            return Math.PI * r * r;
        }

        public double Volume(double r)
        {
            return 4.0/3 * Math.PI * r * r * r;
        }

    }

    delegate double CalcFigures(double r);

    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessFigures pf = new ProcessFigures();

            CalcFigures cf = new CalcFigures(pf.Area);

            double x = cf(2.5);

            WriteLine("x = {0:f2}", x);


            CalcFigures[] A = new CalcFigures[3];

            A[0] = pf.Area;
            A[1] = pf.Volume;
            A[2] = pf.Length;

            foreach (CalcFigures c in A)
            {
                x = c(3.2);
                WriteLine("x = {0:f3}", x);
            }

            ReadLine();
        }
    }
}
