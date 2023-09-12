using System;
using System.Collections;
using static System.Console;
using static System.Convert;


namespace ConsoleApp1
{
    class ArrayDouble : IEnumerator, IEnumerable
    {
        private double[] AD;
        private int index;

        public ArrayDouble()
        {
            AD = new double[] { 1.5, 3.8, 1.7, 7.2, 13.4 };

            index = -1;
        }

        public object Current
        {
            get
            {
                return AD[index];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (index == AD.Length-1)
            {
                Reset();
                return false;
            }
            index++;
            return true;
        }

        public void Print(string msg)
        {
            Write(msg + " => ");
            foreach(double d in AD)
            {
                Write(d + " ");
                WriteLine();
            }
        }

        public void Reset()
        {
            index = -1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayDouble AD = new ArrayDouble();
            AD.Print("AD");

            WriteLine();
            WriteLine("AD:");
            foreach (double d in AD)
                Write(d + " ");

            ReadKey();
        }
    }
}
