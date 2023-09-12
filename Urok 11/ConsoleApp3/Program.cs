using System;
using System.Reflection;
using static System.Console;
using static System.Convert;


namespace ConsoleApp1
{
    
    class Book
    {
        public string title;
        public string author;

        public Book(string _title, string _author)
        {
            title = _title;
            author = _author;
        }

        public void Read()
        {
            WriteLine("Title: {0}, Author: {1}", title, author);
        }
    }

    delegate void TReadBook();

    class DispatchBook
    {
        public event TReadBook EventReadBook;
    
        public void ReadBook()
        {
            if (EventReadBook != null)
            {
                EventReadBook();
            }
        }
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("t-1", "a-1");
            Book b2 = new Book("t-2", "a-2");
            Book b3 = new Book("t-3", "a-3");

            DispatchBook dp = new DispatchBook();


            dp.EventReadBook += b1.Read;
            dp.EventReadBook += b2.Read;
            dp.EventReadBook += b3.Read;

            dp.ReadBook();

            dp.EventReadBook -= b2.Read;

            WriteLine("---------------------------------");

            dp.ReadBook();

            TReadBook rb;
            rb = b1.Read;

            WriteLine("-------------------------------------");

            rb();

            rb += b2.Read;
            rb += b3.Read;

            rb();

            rb = null;

            //dp.EventReadBook = null;
            //dp.EventReadBook = b1.Read;


            rb = b3.Read;
            rb.Invoke();

            //dp.EventReadBook;








            ReadLine();
        }
    }
}
