using System;
using static System.Console;
using System.Collections;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

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

            for (int i = 0; i < AL.Count; i++)
                WriteLine("{0}  ", AL[i]);
            WriteLine();


            ArrayList AL2 = (ArrayList)AL.Clone();
            AL[0] = 500;
            
            for (int i = 0; i < AL2.Count; i++)
                WriteLine("{0}  ", AL2[i]);

            bool f_is = AL.Contains(30);
            WriteLine(f_is);

            ReadKey();
        }
    }
}
