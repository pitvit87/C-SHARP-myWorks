using System;
using static System.Console;
using static System.Convert;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abcd";
            String s2 = "abcd";

            char[] AC = { 'H', 'e', 'l', 'l', 'o' };
            string s3 = new string(AC);
            WriteLine(s3);

            string s4 = @"C:\Programs\1.txt";
            WriteLine(s4);

            Console.ReadKey();
        }
    }
}
