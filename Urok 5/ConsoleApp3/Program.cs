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
            this.name = "wewee";
            this.age = 35;
        }

        public void Print(string msg)
        {
            Write(msg+ " => ");
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
            Person person1, person2;
            person1.name = "Jonson";
            person1.age = 25;

            person2.name = "Ericsson";
            person2.age = 30;

            person2 = person1;
            person1.Print("person1");
            person2.Print("person2");

            person2.name = "Jackson";
            person2.age = 45;
            WriteLine("----------");
            person1.Print("person1");
            person2.Print("person2");

            PersonObj pObj1 = new PersonObj();
            PersonObj pObj2 = new PersonObj();

            pObj1.name = "Johnson"; pObj1.age = 25;
            pObj2.name = "Ericsson"; pObj1.age = 35;

            pObj2 = pObj1;
            WriteLine("----------");
            pObj1.Print("pObj1");
            pObj2.Print("pObj2");

            pObj2.name = "Jassy";
            pObj2.age = 55;
            WriteLine("-----------");

            pObj1.Print("pObj1");
            pObj2.Print("pObj2");

            ReadKey();
        }
    }
}
