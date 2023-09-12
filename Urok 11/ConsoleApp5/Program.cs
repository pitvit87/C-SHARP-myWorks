using System;
using System.Reflection;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;


namespace ConsoleApp1
{
    class Value<T>
    {
        private T a;

        public Value(T _a)
        {
            a = _a;
        }

        public T Get()
        {
            return a;
        }

        public void Set(T _a)
        {
            a = _a;
        }

        public void Print(string msg)
        {
            WriteLine(msg + a);
        }

        //public T Add(T _a, T _b)
        //{
         //   a = _a + _b;
         //   return a;
       // }

        public double Add2(T _a, T _b)
        {
            double res = Convert.ToDouble(_a) + Convert.ToDouble(_b);
            return res;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Value<double> vd = new Value<double>(2.5);

            double x;

            x = vd.Add2(3.8, 4.5);
            WriteLine("x = " + x);


            Value<float> vd2;

            ReadLine();
        }
    }
}
