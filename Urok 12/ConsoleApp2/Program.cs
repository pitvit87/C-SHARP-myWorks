using System;
using static System.Console;
using System.Collections;

namespace ConsoleApp1
{
    struct Book
    {
        public string title;
        public int year;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList AL = new ArrayList();

            AL.Add(10);
            AL.Add(20);
            AL.Add(30);

            int[] AI = (int[])AL.ToArray(typeof(int));

            for (int i = 0; i < AL.Count; i++)
                WriteLine("{0}", (int)AL[i]);

            int number = (int)AL[0];
            
            ReadKey();
        }
    }
}
