using System;
using static System.Convert;
using static System.Math;
using static System.Console;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            float[] A;
            float average;

            Write("Enter size:");
            //size = int.Parse(ReadLine());
            size = ToInt32(ReadLine());

            if (size <= 0)
            {
                WriteLine("Incorrect size.");
                ReadKey();
                return;
            }

            A = new float[size];

            for(int i = 0; i < A.Length; i++)
            {
                Write("A[{0}] = ", i);
                A[i] = Single.Parse(ReadLine());
            }

            WriteLine("----------------------------");
            for (int i = 0; i < A.Length; i++)
                Write(A[i] + "\t");
            WriteLine();

            average = 0.0f;
            for (int i = 0; i < A.Length; i++)
                average += A[i];
            average /= A.Length;

            WriteLine($"average = {average:f3}");

            ReadKey();
        }
    }
}
