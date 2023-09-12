using System;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace ConsoleApp1
{
    class Integer
    {
        private int value;

        public Integer(int value)
        {
            this.value = value;
        }

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        
        public override string ToString()
        {
            return "value = " + value;
        }

        public static Integer operator -(Integer obj)
        {
            Integer obj2 = new Integer(-obj.value);
            return obj2;
            // return new Integer(-obj.value);
        }

        public static Integer operator ++(Integer obj)
        {
            return new Integer(obj.value + 5);
        }

        public static Integer operator !(Integer obj)
        {
            if (obj.value < 1)
                return new Integer(0);

            int res = 1;
            for (int i = 1; i <= obj.value; i++)
                res = res * i;
            return new Integer(res);
        }

        public static Integer operator +(Integer obj1, Integer obj2)
        {
            return new Integer(obj1.value + obj2.value);
        }
        public static Integer operator -(Integer obj1, Integer obj2)
        {
            return new Integer(obj1.value - obj2.value);
        }

        public static int operator%(Integer obj1, Integer obj2)
        {
            int res = obj1.value % obj2.value;
            return res;
        }

        public static bool operator == (Integer obj1, Integer obj2)
        {
            return obj1.value == obj2.value;
        }

        public static bool operator !=(Integer obj1, Integer obj2)
        {
            return !(obj1 == obj2);
            //return obj1.value != obj2.value;
        }

        public static bool operator >(Integer obj1, Integer obj2)
        {
            return obj1.value > obj2.value; 
        }

        public static bool operator <(Integer obj1, Integer obj2)
        {
            return obj1.value < obj2.value;
        }

        public static bool operator true(Integer obj)
        {
            return obj.value != 0;
        }

        public static bool operator false(Integer obj)
        {
            return obj.value == 0;
        }

        public static bool operator&(Integer obj1, Integer obj2)
        {
            
            if (obj1.value != 0 && obj2.value != 0)
                return true;
            return false;
        }

        public static Integer operator|(Integer obj1, Integer obj2)
        {
            if (obj1.value == 0 && obj2.value == 0)
                return new Integer(0);
            return new Integer(1);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Integer i1 = new Integer(10);
            //Integer i2;
            //i2 = -i1;
            //WriteLine(i2);

            //i2++;
            //WriteLine("i2: " + i2);

            //i2 = new Integer(5);
            //i1 = !i2;
            //WriteLine("i1: " + i1);

            //Integer i3 = i2 + i1 + i1 + i2;
            //WriteLine("i3 = " + i3);

            //i3 += i2;
            //WriteLine("i3(+) = " + i3);

            //i3 -= i1;
            //WriteLine("i3(-) = " + i3);

            //i1.Value = 17;
            //i2.Value = 5;
            //int result = i1 % i2;
            //WriteLine("i1 % i2 = " + result);
            
            //result %= i1%i2;

            //WriteLine("result % i1 % i2 = " + result);

            Integer i1 = new Integer(10);

            if (i1)
                WriteLine("true");
            else
                WriteLine("false");

            Integer i2 = new Integer(0);

            if (i2 & i1)
                WriteLine("i2 & i1 => true");
            else 
                WriteLine("i2 & i1 => false");

            Integer i3 = i1 | i2;
            WriteLine("I3 = " + i3);

            i1.Value = 0;
            i2.Value = 0;
            i3 = i1 || i2;
            WriteLine("i3 = " + i3);

            ReadKey();
        }
    }
}
