using System;
using System.IO;
using static System.Console;




namespace ConsoleApp1
{
    class Book
    {
        string title;
        private string name;
        private decimal price;
        private int year;

        private static uint countObjects;


        static Book()
        {
            countObjects = 100;
        }

        public Book(string title, string name, decimal price, int year)
        {
            this.title = title;
            this.name = name;
            this.price = price;
            this.year = year;
            countObjects++;
        }

        public Book() : this("", "", (decimal)0.0, 1990)
        {

        }

        public string GetTitle() { return title; }
        public string GetName() { return name; }
        public decimal GetPrice() { return price; }
        public int GetYear() { return year; }

        public void SetTitle(string title) { this.title = title; }
        public void SetName(string name) { this.name = name; }
        public void SetPrice(decimal price) { this.price = price; }
        public void SetYear(int year) { this.year = year; }

        public string Title
        {
            get { return title; }

            set { title = value; }
        }

        ~Book()
        {

        }


        public void Print(string msg)
        {
            WriteLine(msg);
            WriteLine("Title: " + title);
            WriteLine("Name: " + name);
            WriteLine("Price: {0:f2}", price);
            WriteLine("Year: " + year);
        }

        public override string ToString()
        {
            string s = "Title: " + title + "\n";
            s += "Name: " + name + "\n";
            s += String.Format($"Price: {price:f2}\n");
            s += "Year: " + year + "\n";
            return s;
        }

        public static uint GetCountObjects() { return countObjects; }

        public static void Print(Book B, string msg)
        {
            Write(msg + " => ");
            Write("Title: " + B.GetTitle());
            Write(", Name: " + B.GetName());
            Write(", Year: " + B.GetYear());
            WriteLine(", Price: {0:f2}", B.GetPrice());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book B1 = new Book("t-1", "n-1", (decimal)10.55, 2010);

            Book.Print(B1, "B1");

            ReadKey();
        }
    }
}
