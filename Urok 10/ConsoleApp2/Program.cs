using System;
using System.Collections;
using static System.Console;
using static System.Convert;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello";

            IEnumerator enumerator = s.GetEnumerator();
            while(enumerator.MoveNext())
            {
                char c = (char)enumerator.Current;
                Write(c);
            }

            WriteLine();

            //--------------
            foreach(char c in s)
                Write(c);
            WriteLine();

            ReadKey();
        }
    }
}
