using System;
using static System.Console;

namespace ConsoleApp1
{
    interface IMAthFunctions
    {
        double GetPi();

        double Square(double x);

        double Pi { get; }

        double Sqrt(double x);
    }

    class Myclass : IMAthFunctions
    {
        public double Pi
        {
            get { return Math.PI; }
        }
        public double GetPi()
        {
            return Math.PI;
        }

        public double Sqrt(double x)
        {
            return Math.Sqrt(x);

        }

        public double Square(double x)
        {
            return x * x;
        }
    }

    interface IIndex
    {
        double this[int index]
        {
            get; set;
        }
    }

    class DoubleArrey : IIndex 
    {
        double[] AD = { 1.1, 2.2, 3.3, 5.5 };

        public double this[int index] 
        {
            get
            {
                if (index < 0 || index > AD.Length)
                    throw new IndexOutOfRangeException();
                return AD[index];
            }

            set
            {
                if (index < 0 || index > AD.Length)
                    throw new IndexOutOfRangeException();
                AD[index] = value;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IMAthFunctions mf;

            Myclass mc = new Myclass();

            mf = mc;

            double x = 25;
            double res = mf.Sqrt(x);
            WriteLine("res = {0:f3}", res);

            double r = 2.0;
            res = mf.Pi * r * r;
            WriteLine("res = {0:f3}", res);
            WriteLine("-------------------------");

            DoubleArrey DA = new DoubleArrey();

            IIndex ii = DA;
            double t = ii[3];

            WriteLine("t = {0:f3}", t);

            ii[2] = 9.5;
            t = ii[2];
            WriteLine("ii[2] = {0:f2}", t);


            ReadKey();
        }
    }
}
