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
        static void GenerateException()
        {
            throw new MyClassException1("abcd");
        }

        static void Main(string[] args)
        {
            try
            {
                throw new MyClassException1();
            }
            catch (MyClassException1 e)
            {
                WriteLine(e.Message);
            }

            MyClassException2 mc2 = new MyClassException2();

            try
            {
                throw mc2;
            }
            catch (MyClassException2 e)
            {
                WriteLine("-------------------------");
                WriteLine(e.Message);
            }

            MyClassException3 mc3 = new MyClassException3("This is MyClassException3 exception.");

            try
            {
                throw mc3;
            }
            catch (MyClassException3 e)
            {
                WriteLine("-------------------------");
                WriteLine(e.Message);
            }

            try
            {
                GenerateException();
            }
            catch (MyClassException1)
            {
                WriteLine("-------------------------");
                WriteLine("ok!");
            }


            ReadKey();
        }
    }
}
