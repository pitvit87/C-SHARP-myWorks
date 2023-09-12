using System;
using System.Text;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace Yevtukh_KolomiietsC_DZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1;   // обявили змінні
            double max = 0;
            StringBuilder masStr = new StringBuilder();
            char c = '\n';
            WriteLine("Task 1");
            Write("Enter chars in random line:\n");
            string s = ReadLine(); // вызначили рядок
            Write("line is " + s + ".\n");
            for (int i = 0; i < s.Length; i++) // досліджуємо рядок
            {
                if ((i+1)<s.Length) // перевірка до предостаннього символу
                {
                    if (s[i] == s[i + 1]) // якщо символи тотжні
                    {
                        count++;
                    }
                    else
                    {
                        if (max < count) // якщо не тотожні
                        {
                            max = count;
                            c = s[i];
                        }
                        count = 1;
                    }
                }
                else // перевірка останнього символу, щоб не війти за розмір строчки
                {
                    if (s[i] == s[i - 1])
                    {
                        if (max < count)
                        {
                            max = count;
                            c = s[i];
                        }
                    }
                }
            }

            for (int i = 0; i < max; i++) // створюэмо рядом масСТР
            masStr.Insert(i, c.ToString());

            WriteLine("Max = " + max); // выводимо на экран
            WriteLine("masStr = " + masStr);
            WriteLine("--------------------------");
            WriteLine("Task 2");// друга задача

            WriteLine("Input array size:");
            int n = int.Parse(ReadLine());
            
            double min = 0;
            max = 0;

            double[] arr = new double[n];

            Random rand = new Random(); // створюємо масив випадковіх чисел з перевіркою на макс та мін
            for (int i = 0; i<arr.Length; i++)
            {
                arr[i] = rand.NextDouble()*10-5;
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
                Write($"{arr[i]:f2}" + "  "); // з виводом на єкран №1
            }
            WriteLine();
            WriteLine("max = " + $"{max:f2}");// №2
            WriteLine("min = " + $"{min:f2}");// №3

            ReadKey();
        }
    }
}
