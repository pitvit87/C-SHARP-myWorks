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

            for (int i = 0; i < AD.Length; i++)
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
            int num1, num2, res = 0;

            Write("num1 = ");
            num1 = ToInt32(ReadLine());

            Write("num2 = ");
            num2 = ToInt32(ReadLine());

            try
            {
                res = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                WriteLine("Divide by Zero.");
                res = 0;
            }
            finally
            {
                WriteLine("res = {0}", res);
            }

            ReadKey();
        }
    }
}
