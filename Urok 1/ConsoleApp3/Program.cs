using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year, month, days;

            Console.Write("Year = ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Months = ");
            month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    if (year % 400 == 0)
                        days = 29;
                    else
                    if (year % 100 == 0)
                        days = 28;
                    else
                        if (year % 4 == 0)
                        days = 29;
                    else 
                        days = 28;
                    break;
                default:
                    days = 31;
                    break;
            }

            Console.WriteLine("days = " + days);

            Console.ReadKey();
        }
    }
}
