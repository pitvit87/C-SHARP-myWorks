using System;
using static System.Console;
using static System.Math;


namespace ConsoleApp1
{
    struct Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            string s = "(" + String.Format($"{x:f2}");
            s += "; " + String.Format($"{y:f2})");
            return s;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }
    }


    class MatrixPoint
    {
        Point[,] AP;

        public MatrixPoint(uint m, uint n)
        {

            AP = new Point[m, n];

            Random rnd = new Random();
            for (int i = 0; i < AP.GetLength(0); i++)
                for (int j = 0; j < AP.GetLength(1); j++)
                {
                    AP[i, j] = new Point(rnd.NextDouble() * 10 - 5, rnd.NextDouble() * 10 - 5);
                    AP[i, j].ToString();
                }
        }
        
        public MatrixPoint() : this(0, 0)
        { }

        public override string ToString()
        {
            string s1 = " => ";
            for (int i = 0; i < AP.GetLength(0); i++)
            {
                for (int j = 0; j < AP.GetLength(1); j++)
                    s1 += AP[i, j].ToString() + " ";
                s1 += "\n";
            }
            return s1;
        }

        public Point[] this[uint row]
        {
            get
            {
                if (row >= AP.GetLength(1))
                    throw new IndexOutOfRangeException();
                Point[] result = new Point[AP.GetLength(1)];
                for (int i = 0; i < result.Length; i++)
                    result[i] = AP[row, i];

                return result;
            }
        }

        public double this[uint i, uint j]
        {
            get
            {
                if (i >= AP.GetLength(0))
                    throw new IndexOutOfRangeException();
                return Sqrt(Pow(AP[i, j].X,2) + Pow(AP[i,j].Y,2));
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                MatrixPoint pt1 = new MatrixPoint(3, 4);
                WriteLine(pt1.ToString());

                WriteLine("------------------------------------------------------");

                Point[] A = pt1[1];
                for (int i = 0; i < A.Length; i++)
                    Write(A[i] + " ");
                WriteLine();
                WriteLine("------------------------------------------------------");

                double D = pt1[2, 3];
                WriteLine($"Distanc = {D:f2}");
                

                ReadKey();
            }

        }

    }
}
