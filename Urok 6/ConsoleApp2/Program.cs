using System;
using static System.Console;


namespace ConsoleApp2
{
    enum Month
    {
        January = 31,
        February = 28,
        March = 31,
        April = 30,
        May = 31,
        June = 30
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            Month mn = Month.April;
             

            switch(mn)
            {
                case Month.February:
                    WriteLine("February - 28 days");
                    break;
                case Month.March:
                    WriteLine("March - 31 days");
                    break;
                case Month.April:
                    WriteLine("April - 30 days");
                    break;
                default:
                    WriteLine("Incorrect month");
                    break;

            }

            ReadKey();

        }
    }
}
