using System;
using static System.Console;

namespace ConsoleApp1
{
    interface IA
    {
        void ShowA();
    }

    interface IB : IA
    {
        void ShowB();
    }

    interface IC 
    {
        void ShowC();
    }

    class MyClass : IA, IB, IC
    {
        public void ShowA()
        {
            WriteLine("MyClass.ShowA()");
        }

        public void ShowB()
        {
            WriteLine("MyClass.ShowB()");
        }

        public void ShowC()
        {
            WriteLine("MyClass.ShowC()");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            IA refA;
            IB refB;
            IC refC;

            refA = mc;
            refA.ShowA();
            refB = mc;
            refB.ShowA();
            refB.ShowB();

            refC = mc;
            refC.ShowC();
            

            ReadKey();
        }
    }
}
