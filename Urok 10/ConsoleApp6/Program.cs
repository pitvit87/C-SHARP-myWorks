using System;
using System.Collections;
using static System.Console;
using static System.Convert;


namespace ConsoleApp1
{
    class MyClassException1 : ApplicationException
    {
        private string msg;

        public DateTime TimeException
        {
            get;
            private set;
        }

        public MyClassException1()
        {
            msg = "This is MyClassException";
            TimeException = DateTime.Now;
        }

        public MyClassException1(string msg)
        {
            this.msg = msg;
            TimeException = DateTime.Now;
        }

        public override string Message
        {
            get { return msg; }
        }


    }

    class MyClassException2 : ApplicationException
    {
        public DateTime TimeException
        {
            get;
            private set;
        }

        public MyClassException2() : base("This is MyClassException2 exception")
        {
            TimeException = DateTime.Now;
        }

        public MyClassException2(string msg) : base(msg)
        {
            TimeException = DateTime.Now;
        }

    }


    [Serializable]
    public class MyClassException3 : Exception
    {
        public MyClassException3() { }
        public MyClassException3(string message) : base(message) { }
        public MyClassException3(string message, Exception inner) : base(message, inner) { }
        protected MyClassException3(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    internal class Program
    {
        

        static void Main(string[] args)
        {
            byte d = 100;

            WriteLine("d = {0}", d);

            d = (byte)(d + 200);
            WriteLine("d = {0}", d);

            d = 255;

            try
            {
                checked
                {
                    d = d++;
                }
            }
            catch (OverflowException e)
            {
                WriteLine(e.Message);
            }

            d = 255;
            try
            {
                unchecked { d = d++; }
            }
            catch (OverflowException e)
            {
                WriteLine(e.Message);
            }

            WriteLine("d = {0}", d);

            WriteLine("-----------------------------");
            d = 100;

            try 
            {
                d = (byte)(d + 200);

                WriteLine("d = {0}", checked(d));
            }
            catch (OverflowException e)
            {
                WriteLine(e.Message);
            }

            ReadKey();
        }
    }
}
