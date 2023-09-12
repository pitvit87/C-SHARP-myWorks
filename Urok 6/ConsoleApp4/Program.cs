using System;
using static System.Console;


namespace ConsoleApp4
{
    enum Month
    {
        January = 1,
        February,
        March = 55,
        April,
        May = 90,
        June
    };

    static class StaticClass
    {
        private static double Length = 155.45;

        static StaticClass()
        {
            Length = 200.55;
        }

        static public int a = 100;
    
        static public void StaticMethod()
        {
            WriteLine("Hello, World!");
        }

        public static void DisplayLength()
        {
            WriteLine("Length = {0:f2}", Length);
        }
    }

    class A
    {
        static A()
        {
            a = 120;
        }

        public void Method()
        {
            A objA1 = new A();
            A objA2 = new A();
            objA1.Equals(objA2);

            System.Object.Equals(objA1, objA2);
        }

        protected static int a = 75;
    }

    class B : A 
    {
        public void PrintA()
        {
            WriteLine("a = " + A.a);
        }
    }

    class NonStaticClass
    {
        public static int a = 25;
        public int b = 35;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int t = StaticClass.a;
            WriteLine("t = " + t);

            StaticClass.StaticMethod();

            //double x = StaticClass.Length;

            StaticClass.DisplayLength();

            B objB = new B();
            objB.PrintA();

            ReadKey();

        }
    }
}
