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
            string s1 = "abc sdfewrfabc sderfwefabc";
            string s2;
            s2 = s1.Replace("abc", "AAAAA");
            WriteLine(s2);

            s1 = "0123456789";
            s2 = s1.Insert(3, "AAA");
            WriteLine(s1);
            WriteLine(s2);

            s1 = "0123456789";
            s2 = s1.Remove(5, 1);
            WriteLine(s2);

            s1 = "0123456789";
            char c = '+';
            s2 = s1.Remove(5, 1).Insert(5,c.ToString());
            //s2 = s2.Insert(5, "+");
            WriteLine(s2);

            s1 = "aaa, bbb, ascwe;g.fw, eee";
            //s1 = "aaa bbb ascwe gfweee";
            char[] AC = { '.', ' ', ',', ';' };
            string[] strings;

            strings = s1.Split(AC, StringSplitOptions.RemoveEmptyEntries);
            //strings = s1.Split(AC);


            WriteLine("----------------------------");
            for(int i = 0; i < strings.Length; i++) 
            {
                WriteLine(strings[i]);
            }

            string[] strings2 = { "abc", "def", "111", "2342", "skldj" };

            s1 = String.Join("+++", strings2);
            WriteLine(s1);

            Console.ReadKey();
        }
    }
}
