using System;
using static System.Console;
using System.Collections;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApp1
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            object a;

            a = 300;

            int t;

            t = (int)a;

            WriteLine("a = {0}", a);
            WriteLine("t = {0}", t);

            ReadKey();
        }
    }
}
