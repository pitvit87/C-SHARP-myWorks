using System;
using static System.Console;
using static System.Math;

namespace Yevtukh_KolomietsSamostJob
{
    class Triangle // оголошеня класу
    {
        private double x1;
        private double y1;
        private double x2;
        private double y2;
        private double x3;
        private double y3;

        private static int countTriangle = 0; // змінна створення трикутника

        private static int getArea = 0; // змінна підрахунку площі

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3) // конструктор з параметрами
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            countTriangle++;// підрахунок об'єктів класу тріангл
        }

        public int GetNumTriangle() { return countTriangle; } // функція що повертає кількість трикутників
        public int GetArea() { return getArea; } // функція що повертає кількість підрахованних площ трикутника

        public Triangle() : this(0.0, 0.0, 0.0, 0.0, 0.0, 0.0) // конструктор за замовченням
        { }

        public double GetX1() { return x1; } // геттери
        public double GetY1() { return y1; }
        public double GetX2() { return x2; }
        public double GetY2() { return y2; }
        public double GetX3() { return x3; }
        public double GetY3() { return y3; }

        public void SetX1(double x1) { this.x1 = x1; } // сеттери
        public void SetY1(double y1) { this.y1 = y1; }
        public void SetX2(double x2) { this.x2 = x2; }
        public void SetY2(double y2) { this.y2 = y2; }
        public void SetX3(double x3) { this.x3 = x3; }
        public void SetY3(double y3) { this.y3 = y3; }

        public void Print(string msg) // вивід на єкран
        {
            Write("Triangle " + msg + ":\n");
            Write("(x1;y1)=(" + x1 + ";" + y1 + ")\n");
            Write("(x2;y2)=(" + x2 + ";" + y2 + ")\n");
            Write("(x3;y3)=(" + x3 + ";" + y3 + ")\n");
            WriteLine("Num Triangle = " + GetNumTriangle() + "\n"); // з віводом на єкран
        }

        public static double Length(double x1, double y1, double x2, double y2) // статична функція підрахунку сторони трикутника
        {
            return Sqrt(x1 * x2 + y1 * y2);
        }

        public double p(double a, double b, double c) // підрахунок півпериметру
        {
            double p = (a + b + c) / 2;
            return p;
        }

        public double GetArea(double p, double a, double b, double c) // підрухунок площі
        {

            double s = Sqrt(p * (p - a) * (p - b) * (p - c));
            getArea++;
            return s;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Triangle tr1 = new Triangle(2.3, 2.7, 5.7, 8.6, 2.7, 5.8); //об'ект Тріангл
                tr1.Print("tr1");
                WriteLine("a = " + Triangle.Length(2.3, 2.7, 5.7, 8.6)); // підрахунок сторони 1
                WriteLine("b = " + Triangle.Length(5.7, 8.6, 2.7, 5.8)); // підрахунок сторони 2
                WriteLine("c = " + Triangle.Length(2.7, 5.8, 2.3, 2.7)); // підрахунок сторони 3
                WriteLine("Area triangle = " + tr1.GetArea(tr1.p(Triangle.Length(2.3, 2.7, 5.7, 8.6), Triangle.Length(5.7, 8.6, 2.7, 5.8),
                    Triangle.Length(2.7, 5.8, 2.3, 2.7)), Triangle.Length(2.3, 2.7, 5.7, 8.6),
                    Triangle.Length(5.7, 8.6, 2.7, 5.8), Triangle.Length(2.7, 5.8, 2.3, 2.7))); // підрахунок площі

                WriteLine("Get Area = " + tr1.GetArea()); // вивід на єкран
                
                ReadKey();
            }
        }
    }
}
