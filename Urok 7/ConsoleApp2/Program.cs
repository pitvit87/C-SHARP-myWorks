using System;
using static System.Console;
using System.Deployment.Internal;

using ConsoleApp1;

namespace ConsoleApp2
{
    class A
    {
        public void Show()
        {
            WriteLine("A.Show()");
        }

        public void ShowA()
        {
            WriteLine("A.ShowA()");
        }
    }

    class B : A
    {
        public new void Show()
        {
            WriteLine("B.Show()");
        }

        public void ShowB()
        {
            WriteLine("B.ShowB()");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A objA = new A();
            B objB = new B();

            A refA;

            objA.Show();
            objB.Show();

            refA = objA;
            refA.Show();

            refA = objB;
            refA.Show();

            WriteLine("-----------------------");

            ((B)refA).Show();

            WriteLine("-----------------------");

            if ((refA as B) != null)
                (refA as B).Show();
            else
                WriteLine("refA as B => error.");

            WriteLine("-----------------------");

            if (refA is B)
                (refA as B).Show();
            else
                WriteLine("refA as B => error.");


            ReadKey();
        }
    }
}
