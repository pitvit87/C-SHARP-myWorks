using System;
using static System.Console;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList AL = new ArrayList(10);

            AL.Add("ABCD");
            AL.Add(23);
            AL.Add(100.55);

            WriteLine("AL.Count = " + AL.Count);

            ReadKey();
        }
    }
}
