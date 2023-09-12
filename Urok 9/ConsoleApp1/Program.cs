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

    internal class Program
    {
        static void Main(string[] args)
        {
            IMAthFunctions mf;

            Myclass mc = new Myclass();

            mf = mc;

            double x = 25;
            double res = mf.Sqrt(x);
            WriteLine("res = {0:f3}",res);

            double r = 2.0;
            res = mf.Pi * r * r;
            WriteLine("res = {0:f3}", res);

            ReadKey();
        }
    }
}
