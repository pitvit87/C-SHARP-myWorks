using System;
using static System.Console;
using static System.Convert;
using System.Collections;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "0123456789";
            char c = s1[5];

            string s2 = "Hello";
            s2 = s2 + "!";
            s2 += "!!";
            WriteLine(s2);

            WriteLine(c);

            WriteLine(s2.Length);

            char[] AC = new char[s1.Length];

            s1 = "0123456789";
            s1.CopyTo(0, AC, 0, s1.Length);
            WriteLine(AC);

            AC[5] = '+';
            s1 = new string(AC);
            WriteLine(s1);

            s1 = "abcd";
            s2 = "abcd";
            bool f_equal = s1.Equals(s2);
            WriteLine("f_equal = " + f_equal);

            s1 = "abc";
            s2 = "abcde";
            int res = s1.CompareTo(s2);
            WriteLine("res = " + res);

            s1 = "0123456789";
            s2 = s1.Substring(3, 4);
            WriteLine(s2);

            Console.ReadKey();
        }
    }
}
