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

            //AL.Clear();
            AL.Remove(20);
            AL.RemoveAt(0);

            for (int i = 0; i<AL.Count;i++)
              WriteLine("{0}  ", AL[i]);   
            


            ReadKey();
        }
    }
}
