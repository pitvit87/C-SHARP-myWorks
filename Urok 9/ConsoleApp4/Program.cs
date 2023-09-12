using System;
using static System.Console;

namespace ConsoleApp1
{
    interface IA
    {
        void ShowA();
        void Show();
    }

    interface IB : IA
    {
        void ShowB();
        new void Show();
    }

    

    class MyClass : IB
    {
        public void ShowA()
        {
            WriteLine("MyClass.ShowA()");
        }

        public void ShowB()
        {
            WriteLine("MyClass.ShowB()");
        }

        void IA.Show()
        {
            WriteLine("IA.Show()");
        }

        void IB.Show()
        {
            WriteLine("IB.Show()");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            
            IA refA;
            IB refB;

            refA = mc;
            refA.Show();

            refB = mc;
            refB.Show();

            ReadKey();
        }
    }
}
