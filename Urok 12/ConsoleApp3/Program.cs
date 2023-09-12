using System;
using static System.Console;
using System.Collections;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApp1
{
    struct Book
    {
        public string title;
        public int year;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book()
            {
                title = "t-1",
                year = 2002
            };

            Book b2 = new Book()
            {
                title = "t-2",
                year = 2008
            };

            ArrayList books = new ArrayList();

            books.Add(b1);
            books.Add(b2);

            Book[] AB = (Book[])books.ToArray(typeof(Book));

            foreach(Book b in AB)
            {
                WriteLine("{0}-{1}", b.title, b.year);
            }


            ReadKey();
        }
    }
}
