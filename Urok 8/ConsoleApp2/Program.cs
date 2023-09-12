using System;
using static System.Console;

namespace ConsoleApp1
{
    
    abstract class Figure
    {
        private string name;

        public Figure(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }

        abstract public double Area();
        
        abstract public double Area2 { get; }

    }

    class Circle : Figure
    {
        private double r, x, y;

        public Circle(double r, double x, double y) : base("Circle")
        {
            this.r = r;
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            string s = "x = " + String.Format("{0:f2}", x);
            s += ", y = " + String.Format("{0:f2}", y);
            s += ", r = " + String.Format("{0:f2}", r);
            return base.ToString() + " " + s;
        }

        public override double Area()
        {
            return Math.PI * r * r;
        }

        public override double Area2
        {
            get
            {
                return Math.PI * r * r;
            }
        }

    }

    class Rectangle : Figure
    {
        private double a, b;

        public Rectangle(double a, double b) : base("Rectangle")
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            string s = "a = " + String.Format("{0:f2}", a);
            s += ", b = " + String.Format("{0:f2}", b);
            return base.ToString() + " " + s;
        }

        public override double Area()
        {
            return a * b;
        }

        public override double Area2
        {
            get
            {
                return a * b;
            }
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            //Figure fg = new Figure("Figure");
            //riteLine(fg);

            Circle circle = new Circle(2.5, 1.6, 2.8);
            WriteLine(circle);
            WriteLine("Circle = {0:f2}", circle.Area());

            Rectangle rect = new Rectangle(2.8, 3.6);
            WriteLine(rect);
            WriteLine("Rectangle = {0:f2}", rect.Area());


            ReadKey();
        }
    }
}
