using System;
using static System.Console;

namespace DZ11_C__Yevtukh_Kolomiiets
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
        public int value = 0;
        public int start = 0;
        Random rnd = new Random();

        public int NextRandom(int min, int max)
        {
            value += rnd.Next(min, max+1);
            return value;
        }
    
    

        public void Reset()
        {
           this.value = 0;
        }

        public void SetStart(int start)
        {
            this.start = start;
        }

        public int Value
        {
            get { return value; }
        }
    }

    class ArrayRandomInt : RandomIntSeries
    {
        int[] A;

        public ArrayRandomInt()
        {
            A = null;
        }

        public ArrayRandomInt(int size, int min, int max)
        {
            if (size > 0)
            {
                A = new int[size];

                IRandomSeries rndint = new RandomIntSeries();
                
                for (int i = 0; i < A.Length; i++)
                {
                    A[i] = rndint.NextRandom(min, max);   
                }
            }
            else
                throw new NotImplementedException();
        }

        public void Print(string msg)
        {
            Write(msg + " => ");
            for (int i = 0; i < A.Length; i++)
                Write(A[i] + "  ");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayRandomInt A = new ArrayRandomInt(8,1,5);
            A.Print("A");
            
            ReadKey();
        }
    }
}
