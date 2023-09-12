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

    class Integer
    {
        public int value;
    }

    class DemoPassParameters
    {
        public void PassBuValue(int value)
        {
            value = 100;
        }

        public void PassByValueObj(Integer obj)
        {
            //obj = new Integer();
            obj.value = 100;
        }

        public void PassByRef(ref int value)
        { 
            value = 100;
        }

        public void PassByRefObj(ref Integer obj)
        {
            obj = new Integer();
            obj.value = 100;
        }

        public void PassByOut(out int value)
        {
            value = 100;
        }

        public void PassByOutObj(out Integer obj)
        {
            obj = new Integer();
            obj.value = 100;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DemoPassParameters demo = new DemoPassParameters();

            int a = 200;
            demo.PassBuValue(a);
            WriteLine("a = " + a);

            Integer obj = new Integer();
            obj.value = 200;
            demo.PassByValueObj(obj);
            WriteLine("obj.value = " + obj.value); 

            a = 200; 
            demo.PassByRef(ref a);
            WriteLine("a = " + a);

            obj.value = 200;
            demo.PassByRefObj(ref obj);
            WriteLine("obj.value = " + obj.value);

            int c;
            demo.PassByOut(out c);
            WriteLine("c = " + c);

            obj.value = 200;
            demo.PassByOutObj(out obj);
            WriteLine("obj.value = " + obj.value);

            ReadKey();
        }

    }
}
