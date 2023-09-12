using System;
using static System.Console;
using static System.Convert;
using System.Collections;
using System.Text;

namespace ConsoleApp2
{
    class Point
    {
        public double x;
        public double y;
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            int[] AI = new int[10];

            for (int i = 0; i < AI.Length; i++)
                AI[i] = i * i;

            foreach (int t in AI)
                Write(t + " ");
            WriteLine();

            int[] AI2 = new int[AI.Length];

            AI.CopyTo(AI2, 0);
            Write("AI2 => ");
            foreach (int t in AI2)
                Write(t + " ");
            WriteLine();

            Point[] AP = new Point[5];

            for (int i = 0; i < AP.Length; i++)
                AP[i] = new Point();

            for (int i = 0; i< AP.Length; i ++)
            {
                AP[i].x = i + 2;
                AP[i].y = i + 5;
            }

            foreach(Point p in AP)
            {
                WriteLine("( {0:f2}; {1:f2})   ", p.x, p.y);
            }
            WriteLine();

            Point[] AP2 = new Point[AP.Length];

            for (int i = 0; i < AP2.Length; i++)
                AP2[i] = new Point();

            for (int i = 0; i < AP2.Length; i ++)
            {
                AP2[i].x = AP[i].x;
                AP2[i].y = AP[i].y;
            }

            Write("AP2 => ");
                foreach (Point p in AP2)
                Write("({0:f2}; {1:f2})", p.x, p.y );
            WriteLine();

            AP2 = AP; // только присвоение посыланий

            uint[] UI = { 5, 2, 3, 100, 200 };
            bool[] B = { true, false, false };
            char[] AB = { '+', '-', '*' };

            uint[] UI2 = (uint[])UI.Clone();

            UI2[0] = 1000;

            Write("UI2 => ");
            foreach (uint t in UI2)
                Write(t + " ");
            WriteLine();

            ReadKey();
        }
    }
}
