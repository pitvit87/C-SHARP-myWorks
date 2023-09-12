using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> numbers = new Dictionary<int, string>();

            numbers.Add(1, "One");
            numbers.Add(2, "Two");
            numbers.Add(3, "Three");
            numbers.Add(4, "Four");

            foreach (KeyValuePair<int, string> pair in numbers)
                WriteLine("{0} : {1}", pair.Key, pair.Value);

            WriteLine("-------------------------------");

            numbers.Remove(3);

            foreach (KeyValuePair<int, string> pair in numbers)
                WriteLine("{0} : {1}", pair.Key, pair.Value);

            WriteLine("-------------------------------");

            string s;
            
            if (!numbers.TryGetValue(1, out s))
            numbers.Add(1, "OneOne");

            foreach (KeyValuePair<int, string> pair in numbers)
                WriteLine("{0} : {1}", pair.Key, pair.Value);

            WriteLine("-------------------------------");

            string s1 = numbers[2];

            WriteLine("s1 = " + s1);
            WriteLine("-------------------------------");
            Dictionary<char, int> CI = new Dictionary<char, int>
            {
                ['1'] = 1,
                ['2'] = 2,
                ['3'] = 3
            };

            foreach (KeyValuePair<char, int> pair in CI)
                WriteLine(pair.Key + " - " + pair.Value);

            ReadKey();
        }
    }
}
