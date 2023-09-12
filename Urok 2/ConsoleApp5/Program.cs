using System;
using static System.Console;
using static System.Convert;
using System.Collections;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder(10);
            StringBuilder sb3 = new StringBuilder("abcd");
            String s1 = "abcd";

            //s1[0] = '+';
            sb3[0] = '+';
            WriteLine(sb3);

            s1 = "01234";
            sb3 = new StringBuilder("01234");
            WriteLine(sb3);

            sb1 = new StringBuilder("0123456789");
            sb1.Insert(3, "AAAAA");
            WriteLine(sb1);
            sb1.Insert(0, 123.45);
            WriteLine(sb1);

            sb1 = new StringBuilder("abclksd abcskd lskabc");
            sb1.Replace("abc", "AAAAA");
            WriteLine(sb1);

            sb1 = new StringBuilder("abcsdlc lskabc lksabc");
            sb1.Remove(10, 5);
            WriteLine(sb1);

            sb1 = new StringBuilder("abcd");
            string s2;
            s2 = sb1.ToString();
            WriteLine(s2);

            sb1 = new StringBuilder("1234");
            WriteLine("sb1.Length = " + sb1.Length);
            WriteLine("sb1.Capasity = " + sb1.Capacity);

            sb1 = new StringBuilder("01234567890123456789");
            WriteLine("sb1.Capasity = " + sb1.Capacity);

            sb1.Remove(0, 5);
            WriteLine("sb1.Capasity = " + sb1.Capacity);

            

            ReadKey();
        }
    }
}
