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

        public static int operator %(Integer obj1, Integer obj2)
        {
            int res = obj1.value % obj2.value;
            return res;
        }

        public static bool operator ==(Integer obj1, Integer obj2)
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

        public static bool operator &(Integer obj1, Integer obj2)
        {

            if (obj1.value != 0 && obj2.value != 0)
                return true;
            return false;
        }

        public static Integer operator |(Integer obj1, Integer obj2)
        {
            if (obj1.value == 0 && obj2.value == 0)
                return new Integer(0);
            return new Integer(1);
        }

        public override bool Equals(object obj)
        {
            return value == ((Integer)obj).value;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }

    struct Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = 35;
        }

        public void Print(string msg)
        {
            Write(msg + " => ");
            WriteLine("name: {0}, age {1}", name, age);
        }
    }

    class PersonObj
    {
        public string name;
        public int age;

        public void Print(string msg)
        {
            Write(msg + " => ");
            WriteLine("name: {0}, age {1}", name, age);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Johnson", 35);
            p1.Print("p1");

            ReadKey();
        }
    }
}
