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

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book B1 = new Book();
            Book B2 = new Book();

            B2 = new Book();

            uint count = Book.GetCountObjects();
            WriteLine("count " + count);

            ReadKey();
        }
    }
}
