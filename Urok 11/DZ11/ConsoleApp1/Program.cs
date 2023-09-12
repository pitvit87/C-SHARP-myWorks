using System;
using static System.Console;
using static System.Convert;

namespace ConsoleApp1
{
    class Calculator
    {
        public double Add(double digit1, double digit2)
        {
            return digit1 + digit2;
        }

        public double Sub(double digit1, double digit2)
        {
            return digit1 - digit2;
        }

        public static double Div(double digit1, double digit2)
        {
            if (digit2 == 0)
            {
                WriteLine("Divide by zero - error!");
                return 0.0;
            }
            else
            {
                return digit1 / digit2;
            }
        }

        public static double Mult(double digit1, double digit2)
        {
            return digit1 * digit2;
        }
    }

    delegate double Operations(double digit1, double digit2); 

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Operations oper;
            double res;
            bool job = true;
            while (job)
            {
                WriteLine("Select a calculator function(1-sum, 2-subtraction, 3-divide, 4-multiply):");
                int choice = ToInt32(ReadLine());
                if (choice == 0) job = false;

                else if (choice < 0 || choice > 4)
                    WriteLine("Wrong chice!");
                else
                {
                    Write("Enter the first digit:");
                    double digit1 = ToDouble(ReadLine());

                    Write("Enter the second digit:");
                    double digit2 = ToDouble(ReadLine());

                    switch(choice)
                    {
                        case 1:
                            oper = calc.Add;
                            res = oper(digit1, digit2);
                            WriteLine("res = {0:f2}", res);
                            break;
                        case 2:
                            oper = calc.Sub;
                            res = oper(digit1, digit2);
                            WriteLine("res = {0:f2}", res);
                            break;
                        case 3:
                            oper = Calculator.Div;
                            res = oper(digit1, digit2);
                            WriteLine("res = {0:f2}", res);
                            break;
                        case 4:
                            oper = Calculator.Mult;
                            res = oper(digit1, digit2);
                            WriteLine("res = {0:f2}", res);
                            break;
                        case 0:
                            job = false;
                            break;
                        default:
                            WriteLine("Wrong choice!");
                            break;
                    }
                }
            }
            ReadKey();
        }
    }
}
