using System;
using System.Collections;
using static System.Console;
using static System.Convert;


namespace ConsoleApp1
{
    class ArrayDouble
    {
        private double[] AD;

        public ArrayDouble(int size)
        {
            Random rnd = new Random();

            AD = new double[size];

            for(int i = 0; i < AD.Length;i++)
               AD[i] = rnd.NextDouble() * 10;
            
        }

        public double this[int index]
        {
            get
            {
                double res;

                try
                {
                    res = AD[index];
                }
                catch (IndexOutOfRangeException e)
                {
                    WriteLine(e.Message);
                    return 0.0;
                }

                return res;
            }
        }


        public void Print(string msg)
        {
            Write(msg + " => ");
            for (int i = 0; i < AD.Length; i++)
                Write(AD[i] + " ");
            WriteLine();
        }


    }



    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayDouble AD = new ArrayDouble(5);
            AD.Print("AD");

            double x = AD[8];
            WriteLine("x = {0:f2}",x);


            x = AD[2];
            WriteLine("x = {0:f2}", x);

            ReadKey();
        }
    }
}
