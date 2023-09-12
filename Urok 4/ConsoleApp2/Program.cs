using System;
using System.Collections.Generic;
using static System.Console;


namespace ConsoleApp1
{
    class Point
    {


        public Point(double x, double y)
        {
            X = x; Y = y;
        }

        public Point() : this(0.0, 0.0)
        { }
        public override string ToString()
        {
            string s = "(" + String.Format("{0:f2}", X);
            s += "; " + String.Format("{0:f2})", Y);
            return s;
        }

        public double X
        {
            get; set;
        }

        public double Y
        {
            get; set;
        }


        public double LengthOrigin
        {
            get
            {
                double len = Math.Sqrt(X * X + Y * Y);
                return len;
            }
        }

        public double XY
        {
            set
            {
                X = value;
                Y = value;
            }
        }

        public static Point OriginPoint
        {
            get
            {
                return new Point(0.0, 0.0);
            }
        }

    }

    class ArrayPoints
    {
        private Point[] A = null;

        public ArrayPoints(uint size)
        {
            A = new Point[size];

            Random rnd = new Random();

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = new Point(rnd.NextDouble() * 10,
                    rnd.NextDouble() * 10);
            }
        }

        public void Print(string msg)
        {
            WriteLine(msg + " => ");
            for (int i = 0; i < A.Length; i++)
                Write(A[i].ToString() + " ");
            WriteLine();
        }
        public Point this[uint index]
        {
            get
            {
                if (index >= A.Length)
                    throw new IndexOutOfRangeException();
                return A[index];

            }
                
            set 
            {
                if (index >= A.Length)
                    throw new IndexOutOfRangeException();
                A[index] = value;
            }

        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayPoints AP = new ArrayPoints(6);
            AP.Print("AP");

            AP[1] = new Point(100, 200);

             
            AP.Print("AP");


            ReadKey();
        }

    }
}
