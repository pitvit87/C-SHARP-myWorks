using System;
using System.Reflection;
using static System.Console;
using static System.Convert;


namespace ConsoleApp1
{
    class ProcessFigures
    {

        public double Length(double r)
        {
            WriteLine("Length");

            return 2 * Math.PI * r;
        }

        public double Area(double r)
        {
            WriteLine("Area");
            
            return Math.PI * r * r;
        }

        public double Volume(double r)
        {
            WriteLine("Volume");

            return 4.0 / 3 * Math.PI * r * r * r;
        }

    }

    delegate double CalcFigures(double r);

    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessFigures pf = new ProcessFigures();

            CalcFigures cf;

            cf = pf.Length;
            cf = cf + pf.Area;
            cf += pf.Volume;
            cf += pf.Length;

            double x;

            x = cf(3.5);
             
            WriteLine("x = {0:f2}", x);



            cf = cf - pf.Length;

            cf -= pf.Area;

            x = cf(2.8);

            //--------------------------------------------------------------------------------------------------------

            cf += pf.Area;

            cf.Invoke(3.5);

            Delegate[] AD = cf.GetInvocationList();

            WriteLine("--------------------------------------------");

            MethodInfo mi;

            for (int i = 0; i < AD.Length; i++)
            {
                mi = AD[i].Method;
                WriteLine(mi.Name);
            }

            
            

            ReadLine();
        }
    }
}
