using System;
using static System.Console;
using static System.Convert;

namespace DZ_9_Kazmirchuk
{
    interface IRandomSeries
    {
        int NextRandom(int min, int max);
        void Reset();
        void SetStart(int start);
        int Value { get; }
    }

    class RandomIntSeries : IRandomSeries
    {
        int startNumber;
        int currentNumber;
        Random random;

        public RandomIntSeries()
        {
            random = new Random();
        }

        public int NextRandom(int min, int max)
        {
            int randomNumber = random.Next(min, max + 1);
            currentNumber += randomNumber;
            return currentNumber;
        }

        public void Reset()
        {
            currentNumber = startNumber;
        }

        public void SetStart(int start)
        {
            startNumber = start;
            currentNumber = start;
        }

        public int Value { get { return currentNumber; } }

    }

    class ArrayRandomInt
    {
        int[] A;

        public ArrayRandomInt(int size, int min, int max)
        {
            RandomIntSeries randomIntSeries = new RandomIntSeries();
            A = new int[size];
            for (int i = 0; i < size; i++)
            {
                A[i] = randomIntSeries.NextRandom(min, max);
            }
        }
        public void Print(string msg)
        {
            Write(msg + " => ");
            for (int i = 0; i < A.Length; i++)
                Write(" " + A[i]);
            WriteLine();
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayRandomInt A = new ArrayRandomInt(8, 1, 5);
            A.Print("A");

            ArrayRandomInt A1 = new ArrayRandomInt(10, 1, 5); 
            A1.Print("A1");
            
            

            ReadKey();
        }
    }
}