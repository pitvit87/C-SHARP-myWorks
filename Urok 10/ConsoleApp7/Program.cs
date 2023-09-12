using System;
using System.Collections;
using static System.Console;
using static System.Convert;


namespace ConsoleApp1
{
   
    internal class Program
    {
        static short MultNumbers(short num1, short num2)
        {
            short result;

            try
            {
                result = checked((short)(num1* num2));

                WriteLine("result = {0}", result);
            }
            catch(OverflowException e)
            {
                WriteLine(e.Message);

                result = 0;

                WriteLine("result = {0}", result);
                throw new Exception("Go to exception filters.", e);
            }

            return result;
        }

        static void Main(string[] args)
        {
           short a, b, result;
            Write("a = ");
            a = ToInt16(ReadLine());
            Write("b = ");
            b = ToInt16(ReadLine());

            try
            {

                result = MultNumbers(a, b);
                WriteLine("a * b = {0}", result);
            }
            catch(Exception e) when (e.InnerException != null)
            {
                WriteLine(@"Exception object, demo of 'when' keyword.");    
            }
            catch (Exception e)
            {
                WriteLine("Exception object.");
            }


            ReadKey();
        }
    }
}
