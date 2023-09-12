using System;
using System.Security.Cryptography.X509Certificates;
using static System.Console;


namespace ConsoleApp5
{
    class Outer
    {
        int a;
        public class Inner
        {  }
    
        public static class InnerStatic
        {
            public static int staticValue = 25;
        }
    }

    class A
    {
        private static int count = 0;

        public A()
        {
            count++
        }

        public int GetCount() { return count; }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Outer.Inner objInner = new Outer.Inner();

            WriteLine("staticValue = " + Outer.InnerStatic.staticValue);

            ReadKey();

        }
    }
}
