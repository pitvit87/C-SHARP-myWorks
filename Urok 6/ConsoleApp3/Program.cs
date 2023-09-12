using System;
using static System.Console;


namespace ConsoleApp2
{
    enum Month
    {
        January = 1,
        February,
        March = 55,
        April,
        May = 90,
        June
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            Month mn;

            try
            {
                mn = Month.April;

                string s = Enum.GetName(typeof(Month), mn);
                WriteLine(s);

                WriteLine("----------------------------");
                
                string[] AS = Enum.GetNames(typeof(Month));
                foreach(string ts in AS)
                    Write(ts + " ");
                WriteLine();

                WriteLine("----------------------------");

                s = (string)Enum.GetNames(typeof (Month)).GetValue(2);
                WriteLine(s);

                WriteLine("----------------------------");

                Array values;
                values = Enum.GetValues(typeof(Month));

                foreach (int i in values)
                    Write(i + " ");
                WriteLine();

                WriteLine("----------------------------");

                int t = (int)Enum.Parse(typeof(Month), "April");
                WriteLine("t = " + t);


                WriteLine("----------------------------");

                if (Enum.IsDefined(typeof(Month), (string)"March"))
                    WriteLine("+++");
                else
                    WriteLine("---");

            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }

            int? a;
            a = 100;
            a = null;


            ReadKey();

        }
    }
}
