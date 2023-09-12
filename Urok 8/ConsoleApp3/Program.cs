using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace ConsoleApp36
{

    // Клас, який описує студентський квиток
    class StudentCard
    {
        public string Series;
        public int Number;
    }

    // Клас, який описує студента в навч. закладі
    class Student
    {
        public string name;
        public int year;  // курс навчання
        public StudentCard StudentCard { get; set; }

        // Перевизначення
        public override string ToString()
        {
            string s = "=> " + name + ",  year = " + year.ToString();
            s += ",  StudentCard: " + StudentCard.Series + " - ";
            s += StudentCard.Number;
            return s;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            // Тема: Поверхневе і глубоке копіювання.
            // У C# розрізняють 3 види копіювання з допомогою опер. =:
            // - копіювання посилань - копіюються тільки посилання,
            //   у результаті 2 об'єкти вказують на ту саму область
            //   пам'яті;
            // - копіювання поверхневе (shallow copy) - копіюються 
            //   повністю типи-значень, для типів-посилань копіюються
            //   тільки посилання;
            // - глубоке копіювання (deep copy) - повна копія даних
            //   в іншій області пам'яті.

            Student st = new Student()
            {
                name = "student-1",
                year = 3,
                StudentCard = new StudentCard()
                {
                    Number = 235,
                    Series = "AK"
                }
            };

            Student st2 = new Student()
            {
                name = " student-2",
                year = 5,
                StudentCard = new StudentCard()
                {
                    Number = 177,
                    Series = "AAB"
                }
            };

            st2 = st;
            WriteLine("st2 = " + st2);

            st.name = "Jonson";
            Write("st2 = " + st2);

            st2.name = st.name;
            st2.year = st.year;
            st2.StudentCard = st.StudentCard;

            
            Student st3 = new Student();
            
            st3.name = st.name;
            st3.year = st.year;
            st3.StudentCard = new StudentCard();
            st3.StudentCard.Number = st.StudentCard.Number;
            st3.StudentCard.Series = st.StudentCard.Series;

            WriteLine();
            WriteLine("----------------------------");
            WriteLine("St = " + st);
            WriteLine("St3 = " + st3);
            st.name = "ABCD";
            st.year = 7777;
            st.StudentCard.Number = 11111;
            st.StudentCard.Series = "BBBBB";
            WriteLine("----------------------------");
            WriteLine("st = " + st);
            WriteLine("st3 = " + st3);

            WriteLine(st3.ToString());

        


            ReadKey();
        }
    }
} 