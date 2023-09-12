using System;
using static System.Console;
using static System.Convert;
using System.Collections;
using System.Text;
using System.Globalization;

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
            int[,] AI = new int[3, 4];

            for (int i = 0; i < AI.GetLength(0); i++)
                for (int j = 0; j < AI.GetLength(1); j++)
                    AI[i, j] = i * j + 2;

            for (int i = 0; i < AI.GetLength(0); i++)
            {
                for (int j = 0; j < AI.GetLength(1); j++)
                    Write(AI[i, j] + " ");
                WriteLine();
            }

            int[,] AI2 =
            {
                {2,3, 4,5 },
                {5,6, 8,9 },
                {1,0, 0,3 }
            };

            Point[,] AP = new Point[3, 4];
            for (int i = 0; i < AP.GetLength(0); i++)
            {
                for (int j = 0; j < AP.GetLength(1); j++)
                {
                    AP[i, j] = new Point();
                    AP[i, j].x = i + j;
                    AP[i, j].y = i * j;
                    Write($"( {AP[i, j].x:f2}; {AP[i, j].y:f2})");
                }
                WriteLine();
            }
            ReadKey();
        }
    }
}
