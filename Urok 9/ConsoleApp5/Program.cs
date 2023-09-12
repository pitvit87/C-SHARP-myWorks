using System;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace ConsoleApp1
{
    class Book : IComparable
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public Book(string title, int year, double price)
        {
            Title = title;    
            Year = year;
            Price = price;
        }

        public int CompareTo(object obj)
        {
            if (obj is Book)
            {
                if (Year < (obj as Book).Year)
                    return -1;
                if (Year == (obj as Book).Year)
                    return 0;
                return 1;
            }

            throw new NotImplementedException();
        }
    }

    class Books 
    {
        public Book[] B;

        public Books()
        {
            B = null;
        }

        public void Add(Book book)
        {
            if (B == null)
            {
                B = new Book[1];
                B[0] = book;
                return;
            }

            Book[] B2 = new Book[B.Length + 1];

            for (int i = 0; i < B.Length; i++)
                B2[i] = B[i];

            B2[B.Length] = book;

            B = B2;
        }

       

        public void Print(string msg)
        {
            WriteLine(msg);
            for (int i = 0; i < B.Length; i++)
                WriteLine("Title: {0},  Year: {1},  Price: {2:f2}",
                    B[i].Title, B[i].Year, B[i].Price);
            WriteLine();
            WriteLine("--------------------------------------");
        }
        
        public void Sort()
        {
            Array.Sort(B);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Books AB = new Books();

            AB.Add(new Book("book-1", 2020, 95.75));
            AB.Add(new Book("book-2", 2022, 53.75));
            AB.Add(new Book("book-3", 2014, 59.25));
            AB.Add(new Book("book-4", 2019, 88.00));

            AB.Print("AB");

            AB.Sort();

            AB.Print("AB+");

            ReadKey();
        }
    }
}
