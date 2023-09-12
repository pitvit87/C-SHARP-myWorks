using System;
using static System.Console;
using System.Runtime.Serialization;

namespace ConsoleAppDZ10_Yevtukh_Kolomiiets
{
    class MyExceptions1 : ApplicationException
    {
        private string msg;

        public DateTime TimeException
        {
            get;
            private set;
        }

        public MyExceptions1()
        {
            msg = "This is MyExcaptions1 exception - Index is negative!";
            TimeException = DateTime.Now;
        }

        public MyExceptions1(string msg)
        {
            this.msg = msg;
            TimeException = DateTime.Now;
        }
        public override string Message
        {
            get { return msg; }
        }
    }

    class MyExceptions2 : ApplicationException
    {
        public DateTime TimeException
        {
            get;
            private set;
        }

        public MyExceptions2() : base("This is MyException2 exception - Index is out of range!")
        {
            TimeException = DateTime.Now;
        }

        public MyExceptions2(string msg) : base(msg)
        {
            TimeException = DateTime.Now;
        }
    }

    [Serializable]
    public class MyExceptions3 : Exception
    {
        public MyExceptions3() { }
        public MyExceptions3(string message) : base(message) { }
        public MyExceptions3(string message, Exception inner) : base(message, inner) { }
        protected MyExceptions3(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }


    class ArrayFloat
    {

        public float[] AF;
        
        public ArrayFloat(int size)
        {
            Random rnd = new Random();
            AF = new float[size];
            for (int i = 0; i < AF.Length; i++)
            {
                AF[i] = rnd.Next(1,11);
            }
        }

        public float this[int index]
        {
            get
            {
                try
                {
                    if (index < 0)
                    {
                        throw new MyExceptions1();
                    }
                    if (index >= AF.Length)
                    {
                        throw new MyExceptions2();
                    }
                    return AF[index];
                }
                catch (MyExceptions1 e)
                {
                    WriteLine(e.Message);
                }
                catch (MyExceptions2 e)
                {
                    WriteLine(e.Message);
                }
                return 0;
            }
            set
            {
                try
                {
                    if (index < 0)
                    {
                        throw new MyExceptions1();
                    }
                    if (index >= AF.Length)
                    {
                        throw new MyExceptions2();
                    }
                    AF[index] = value;
                }
                catch (MyExceptions1 e)
                {
                    WriteLine(e.Message);
                }
                catch (MyExceptions2 e)
                {
                    WriteLine(e.Message);
                }
            }
        }

        public void Set(float value, int index)
        {
            if (index < 0 || index >= AF.Length)
            {
                throw new MyExceptions3("This is MyException3 exception - Invalid index!");
            }
            AF[index] = value;
        }
        public void Print(string msg)
        {
            Write(msg + " => ");
            for (int i = 0; i < AF.Length; i++)
                Write(AF[i] + "  ");
            WriteLine();
        }
    }

        internal class Program
        {
            static void Main(string[] args)
            {
                ArrayFloat AF = new ArrayFloat(10);
                AF.Print("AF");

                float x = AF[-3];
                WriteLine("x = {0:f2}", x);

                x = AF[12];
                WriteLine("x = {0:f2}", x);

                x = AF[8];
                WriteLine("x = {0:f2}", x);

                try
                {
                    AF.Set(7.0f, 11);
                }
                catch (MyExceptions3 e)
                {
                    WriteLine(e.Message);    
                }

                ReadKey();
            }
        }
}
               

    