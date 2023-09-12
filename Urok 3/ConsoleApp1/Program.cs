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

        public static uint countObjects;

        public Book(string title, string name, decimal price, int year)
        {
            this.title = title;
            this.name = name;
            this.price = price;
            this.year = year;
            countObjects++;
        }

        public Book():this("","",(decimal)0.0, 1990)
        {

        }

        public string GetTitle() { return title; }
        public string GetName() { return name; } 
        public decimal GetPrice() { return price; } 
        public int GetYear() { return year; }

        public void SetTitle(string title) { this.title = title;}
        public void SetName(string name) { this.name = name;} 
        public void SetPrice(decimal price) { this.price = price; }
        public void SetYear(int year) { this.year = year;} 
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

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book B1 = new Book("title-1", "name-1", (decimal)100.55, 2020);
            B1.Print("B1");
            WriteLine("--------------------------");
            WriteLine(B1.ToString());

            Book[] AB = new Book[3];

            for (int i = 0; i < AB.Length; i++)
            {
                AB[i] = new Book();
            }

            AB[0].SetTitle("title-1");
            AB[0].SetName("abcd");
            AB[0].SetPrice((decimal)20.33);
            AB[0].SetYear(2002);
            AB[1].SetTitle("title-2");
            AB[1].SetName("wert");
            AB[1].SetPrice((decimal)24.33);
            AB[1].SetYear(2003);
            AB[2].SetTitle("title-3");
            AB[2].SetName("hbsd");
            AB[2].SetPrice((decimal)100.55);
            AB[2].SetYear(2004);

            WriteLine("---------------------------------------");
            foreach (Book b in AB)
                WriteLine(b.ToString());

            ReadKey();
        }
    }
}
