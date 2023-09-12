using System;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol;
            int numSpaces = 0;

            WriteLine("Please, enter characters:");

            do
            {
                symbol = (char)Read();

                if (symbol == ' ')
                    numSpaces++;

            }while(symbol != '.');

            WriteLine("numSpaces = {0,10}", numSpaces);

            ReadKey();
        }
    }
}
