using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using static System.Console;

namespace DZ12
{
    public struct Book
    {
        public string title;
        public string author;
        public int year;
        public decimal price;

        public Book(string title, string author, int year, decimal price)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.price = price;
        }


        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public void Print()
        {
            WriteLine("Title: " + title);
            WriteLine("Author: " + author);
            WriteLine("Year: " + year);
            WriteLine("Price: {0:f2}", price);
        }

        public static bool operator ==(Book obj1, Book obj2)
        {
            return obj1.price == obj2.price;
        }

        public static bool operator !=(Book obj1, Book obj2)
        {
            return !(obj1.price == obj2.price);
        }

        public override bool Equals(object obj)
        {
            return price==((Book)obj).price;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    class QueueBooks
    {
        Queue<Book> QB;


        public QueueBooks()
        {
            QB = new Queue<Book>();
        }

        public QueueBooks(Book[] ABooks)
        {
            QB = new Queue<Book>(ABooks);
        }

        public void AddBook(Book book)
        {
            QB.Enqueue(book);
        }

        public void AddBookAtPos(Book book, int pos)
        {
            if (pos >= QB.Count || pos < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                List<Book> list = new List<Book>();

                while (QB.Count > pos)
                    list.Add(QB.Dequeue());

                list.Insert(pos, book);

                while (QB.Count > 0)
                    list.Add(QB.Dequeue());


                foreach (Book b in list)
                    QB.Enqueue(b);
            }
        }

        public void PrintBooks()
        {
            foreach (Book book in QB)
            {
                book.Print();
                WriteLine("-----------------------------------");
            }
        }

        public Book PopBook()
        {
            return QB.Dequeue();
        }

        public Book PopBookAtPos(uint pos)
        {
            Book temp;
            if (pos >= QB.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                List<Book> list = new List<Book>();

                while (QB.Count > 0)
                    list.Add(QB.Dequeue());

                temp = list.ElementAt((int)pos);
                list.RemoveAt((int)pos);
            
                foreach (Book b in list)
                    QB.Enqueue((Book)b);
            }

            return temp;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Book B1 = new Book("Title-first", "Author-11", 2019, (decimal)125.25);
            Book B2 = new Book("Title-second", "Author-22", 2017, (decimal)125.25);

            B1.Print();
            WriteLine("-----------------------------------");
            B2.Print();
            WriteLine("--------   Check (==/!=)   ---------");

            if (B1 == B2)
                WriteLine("Books price is the same!");
            else
                WriteLine("Books price is not the same!");

            WriteLine("************************************");

            Book[] arrayBooks =
            {
                new Book("Title-1", "Author-1", 2002, (decimal)170.50),
                new Book("Title-2", "Author-2", 2012, (decimal)140.25),
                new Book("Title-3", "Author-3", 2022, (decimal)190.55),
                new Book("Title-4", "Author-4", 2023, (decimal)135.80)
            };

            QueueBooks QB1 = new QueueBooks(arrayBooks);
            QB1.PrintBooks();

            WriteLine("--- Add new Book ---");
            Book book = new Book("Title-5", "Author-5", 2005, (decimal)150.40);
            QB1.AddBook(book);
            QB1.PrintBooks();

            WriteLine("--- Add new Book at Position ---");
            book = new Book("Title-6", "Author-6", 2008, (decimal)120.40);
            try
            {
                QB1.AddBookAtPos(book,2);
                QB1.PrintBooks();
            }
            catch (ArgumentOutOfRangeException e)
            {
                WriteLine(e.Message);
            }

            WriteLine("---Extract First Book---");
            QB1.PopBook().Print();
            WriteLine("---------Result---------");
            QB1.PrintBooks();

            WriteLine("---Extract Book at Position---");
            try
            {
                QB1.PopBookAtPos(3).Print();
                WriteLine("---------Result---------");
                QB1.PrintBooks();
            }
            catch (ArgumentOutOfRangeException e)
            {
                WriteLine(e.Message);
            }


            ReadKey();
        }
    }
    
}




