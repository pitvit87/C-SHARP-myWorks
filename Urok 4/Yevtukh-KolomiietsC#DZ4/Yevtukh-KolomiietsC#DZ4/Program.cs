using System;
using static System.Console;

namespace Yevtukh_KolomiietsC_DZ4
{
    class Topic //Створюємо клас
    {
        private string subject; // приватні поля
        private int number;
        private string name;
        private double difficulty;
        private int points;
        
        public Topic(string subject, int number, string name, double difficulty, int points) // конструктор з 5 параметрами
        {
            this.subject = subject;
            this.number = number;
            this.name = name;
            this.difficulty = difficulty;
            this.points = points;
        }

        public Topic() : this("", 0, "", 0.01, 1) // конструктор за замовченням
        { }

        public string Subject // властівості
        {
            get { return subject; }
            set { subject = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Difficulty
        {
            get { return difficulty; }
            set
            {
                if (value >= 0.01 && value <= 1) // перевірка властивості
                    difficulty = value;
            }
        }
        public int Points
        {
            get { return points; }
            set
            {
                if (value >= 1 && value <= 100) // перевірка властивості
                    points = value;
            }
        }

        public double Rating // властівість Рейтинг через ГЕТ
        {
            get { return points * difficulty; }
        }
        
        public void Print(string msg) // вивід на єкран
        {
            WriteLine(msg + ": ");
            WriteLine("Subject = " + subject);
            WriteLine("Number = " + number);
            WriteLine("Name = " + name);
            WriteLine("Difficulty = " + difficulty);
            WriteLine("Points = " + points);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Topic tp1 = new Topic();        //створили обьект
            tp1.Subject = "C# coding."; // перевіряем властивості через СЕТ
            tp1.Number = 12;
            tp1.Name = "Properties with Get&Set.";
            tp1.Difficulty = 1.32; // тестуємо властівість
            tp1.Difficulty = 0.87;
            tp1.Points = 123; // тестуємо властівість
            tp1.Points = 79;
            tp1.Print("tp1");
            WriteLine("Rating = " + tp1.Rating); // отрімуємо Рейтинг
            WriteLine("------------------");
            Topic Copytp1 = new Topic(); // створюемо другий обєкт для тестування функції ГЕТ
            Copytp1.Subject = tp1.Subject; // перевіряемо функцію ГЕТ
            Copytp1.Number = tp1.Number;
            Copytp1.Name = tp1.Name;
            Copytp1.Difficulty = tp1.Difficulty;
            Copytp1.Points = tp1.Points;
            Copytp1.Print("Copytp1"); // Виводимо результат
            WriteLine("Rating = " + Copytp1.Rating);

            ReadKey();

        }
    }
}
