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
    internal class Program
    {
        static void Main(string[] args)
        {
            Point pt1 = new Point(2.8, 3.5);
            WriteLine("pt1 = " + pt1.ToString());

            pt1.X = 3.3;
            pt1.Y = 7.8;
            WriteLine("pt1 = " + pt1.ToString());

            WriteLine("LengthOrigin(pt1) = {0:f2}", pt1.LengthOrigin);

            pt1.XY = 10.55;
            WriteLine("pt1 = " + pt1);

            Point pt2 = Point.OriginPoint;
            WriteLine("pt2 = " + pt2);

            ReadKey();
        }
    }
}
