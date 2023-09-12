using System;
using static System.Console;

namespace ConsoleApp1
{
    class A
    {
        public virtual void Show()
        {
            WriteLine("A.Show()");
        }
    }

    class B : A
    {
        public override void Show()
        {
            WriteLine("B.Show()");
        }
    }

    class C : B
    {
        public override void Show()
        {
            WriteLine("C.Show()");
        }
    }

    internal class Program
    {
        static void CallShow(A refA)
        {
            refA.Show();
        }

        static void Main(string[] args)
        {
            A objA = new A();
            B objB = new B();
            C objC = new C();

            objA.Show();
            objB.Show();
            objC.Show();   

            A refA;
            refA = objA;
            refA.Show();

            refA = objB;
            refA.Show();
            
            refA = objC;
            refA.Show();

            //--------------------------

            int n;
            WriteLine("---------------------------");
            Write("n = ");
            n = Convert.ToInt32(ReadLine());

            if (n == 1)
                refA = objA;
            else
            if (n == 2)
                refA = objB;
            else
            if (n == 3)
                refA = objC;
            else
                refA = objA;

            CallShow(refA);

            ReadKey();
        }
    }
}
