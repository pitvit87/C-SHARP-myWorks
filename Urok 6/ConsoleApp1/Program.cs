using System;
using static System.Console;



namespace ConsoleApp31
{

    class A
    {
        public int a;



        public override string ToString()
        {
            return "a = " + Convert.ToString(a);
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            // 
            A objA = new A();
            objA.a = 100;
            WriteLine(objA.ToString());

            ReadKey();
        }
    }
}