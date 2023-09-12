using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApp1
{
    public class ConverterCollections
    {
        public Stack ConvertQueueToStack(Queue Q)
        {
            Stack S = new Stack();
            Queue Q2 = new Queue();
            object item;

            while (Q.Count > 0)
            {
                item = Q.Dequeue();

                S.Push(item);

                Q2.Enqueue(item);
            }

            foreach (object t in Q2)
                Q.Enqueue(t);

            return S;
        }

        public void PrintStack(Stack S)
        {
            object item;
            ArrayList AL = new ArrayList();

            while (S.Count > 0)
            {
                item = S.Pop();

                Write(item + "  ");

                AL.Insert(0, item);
            }
            WriteLine();

            foreach (object t in AL)
                S.Push(t);

        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Stack S1 = new Stack(new ArrayList() { 1, 2, 5, 7, 4, });
            Queue Q1 = new Queue(new ArrayList() { 2, 8, 4, 3 });
            ConverterCollections converter = new ConverterCollections();

            Stack S2 = converter.ConvertQueueToStack(Q1);
            converter.PrintStack(S2);
            converter.PrintStack(S2);

            WriteLine("----------------");

            foreach (object t in Q1)
                Write(t + "  ");
            WriteLine();

            ReadKey();
        }
    }
}
