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
            List<int> L1 = new List<int>();

            L1.Add(10);
            L1.Add(20);
            L1.Add(30);

            for (int i = 0; i < L1.Count; i++)
                Write(L1[i] + "  ");
            WriteLine();

            int t;
            t = L1[2];

            L1[2] = t;

            ReadKey();
        }
    }
}
