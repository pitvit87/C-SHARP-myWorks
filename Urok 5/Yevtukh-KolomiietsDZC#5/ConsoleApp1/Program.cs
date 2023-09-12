using System;
using static System.Console;

namespace ConsoleApp1
{
    class Point // створюємо класс
    {
        double x;
        double y;

        public Point(double x, double y) // конструктор з 2 параметрами
        {
            this.x = x;
            this.y = y;
        }

        public Point() : this(0, 0) // конструктор за замовченням
        { }

        public double X // власивості Х
        { get { return x; }
            set { x = value; }
        }

        public double Y // Властивості У
        {
            get { return y; }
            set { this.y = value; }
        }

        public void Print(string msg) // вивід на екран
        {
            WriteLine(msg + " => (" + X + ": " + Y + ")\n");
        }

        public Point(Point obj) // конструктор копіювання
        {
            X = obj.X;
            Y = obj.Y;
        }

        public static Point operator+(Point obj1,Point obj2)    //перевантажуємо оператори згідно завдання
        {                                                       // (бінарні)
            return new Point((obj1.x + obj2.x),(obj1.y+obj2.y));
        }
               
        public static Point operator -(Point obj1, Point obj2)
        {
            return new Point((obj1.x - obj2.x), (obj1.y - obj2.y));
        }
        public static Point operator -(Point obj) // унарні
        {
            return new Point((-obj.x),(-obj.y));
        }

        public static bool operator true(Point obj) // унарні - парні
        {
            return (obj.x == 0.0 && obj.y == 0.0);
        }
        public static bool operator false(Point obj)
        {
            return (obj.x != 0.0 && obj.y != 0.0);
        }

        public static bool operator ==(Point obj1, Point obj2) // бінарні - парні
        {
            return (obj1.x == obj2.x && obj1.y == obj2.y);
        }
        public static bool operator !=(Point obj1, Point obj2)
        {
            return !(obj1 == obj2);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point pt1 = new Point(2.34,5.65); // тестуємо методи
            Point pt2 = new Point(3.76,2.89);
            Point pt3 = pt1 + pt2;
            Point pt4 = pt1 - pt2;
            Point pt5 = -pt1;
            Point pt6 = new Point();
            Point pt7 = new Point(2.34,5.65);
            Point pt8 = new Point(pt2);



            pt1.Print("pt1"); // виводимо на екран
            pt2.Print("pt2");
            pt3.Print("pt3 = pt1 + pt2");
            pt4.Print("pt4 = pt1 - pt2");
            pt5.Print("pt5 = -pt1");
            pt6.Print("pt6");
            pt7.Print("pt7");
            pt8.Print("pt8");

            if (pt6)                            // тестуємо методи тру - фолс
                WriteLine("pt6 == (0.0,0.0)");
            else
                WriteLine("pt6 != (0.0,0.0)");

            if (pt1)
                WriteLine("pt1 == (0.0,0.0)");
            else
                WriteLine("pt1 != (0.0,0.0)");

            if (pt1 == pt7)
                WriteLine("pt1 == pt7 => True");
            else
                WriteLine("pt1 == pt7 => false");

            if (pt1 != pt2)
                WriteLine("pt1 != pt2 => " + (pt1 != pt2));
            else
                WriteLine("pt1 == pt2 => " + (pt1 == pt2));


            ReadKey();
        }
    }
}
