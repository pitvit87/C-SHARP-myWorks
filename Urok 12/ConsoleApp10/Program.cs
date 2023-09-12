using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApp1
{
    class Int
    {
        public int d;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("MaxGeneration = {0}", GC.MaxGeneration);

            Int[] A = new Int[100000];

            int numGen = GC.GetGeneration(A);
            WriteLine("numGen = " + numGen);

            A = new Int[100];

            WriteLine("Alloc Memory = {0}", GC.GetTotalMemory(false));
            WriteLine("Alloc Memory = {0}", GC.GetTotalMemory(true));

            GC.Collect(numGen);
            WriteLine("---------------------");
            WriteLine("Alloc Memory = {0}", GC.GetTotalMemory(false));
            WriteLine("Alloc Memory = {0}", GC.GetTotalMemory(true));

            GC.Collect();
            WriteLine("---------------------");
            WriteLine("Alloc Memory = {0}", GC.GetTotalMemory(false));
            WriteLine("Alloc Memory = {0}", GC.GetTotalMemory(true));


            ReadKey();
        }
    }
}
