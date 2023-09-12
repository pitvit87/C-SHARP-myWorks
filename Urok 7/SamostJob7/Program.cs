using System;
using static System.Console;

namespace SamostJob7
{
    class Student // клас Студент
    {
        public string surname;
        public int kurs;
        public int zalikNumber;

        public Student(string surname, int kurs, int zalikNumber) // конструктор з 3 параметрами
        {
            this.surname = surname;
            this.kurs = kurs;
            this.zalikNumber = zalikNumber;
        }

        public Student() : this("", 0, 0) // конструктор за замовченням
        { }

        

        public void Print(string msg) // вивід на єкран
        {
            WriteLine(msg + " = > " + surname + ", " + kurs + ", " + zalikNumber + ";");
        }

    }

    class Aspirant : Student // клас Аспирант, що наслідує клас Студент
    {
        bool zahistKondidatskoy;

        public Aspirant(string surname, int kurs, int zalikNumber, bool zahistKondidatskoy) : base(surname, kurs, zalikNumber) // конструктор з параметрами
        {
            this.zahistKondidatskoy = zahistKondidatskoy;
        }

        public Aspirant() : this("", 0, 0, false) // конструктор за замовченням
        { }

        public string Surname // властивості
        {
            get { return surname; }
            set { surname = value; }
        }

        public int Kurs
        {
            get { return kurs; }
            set { kurs = value; }
        }
        public int ZalikNumber
        {
            get { return zalikNumber; }
            set { zalikNumber = value; }
        }
        public bool ZahistKondidatskoy // властивості
        {
            get { return zahistKondidatskoy; }
            set { zahistKondidatskoy = value; }
        }

        public new void Print(string msg) // вівід на єкран з наслідуванням
        {
            base.Print(msg);
            WriteLine("Status zahistu kondidatskoi roboti - " + ZahistKondidatskoy + ".");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Aspirant as1 = new Aspirant();
            as1.Surname = "Ivanov"; // тестуэмо властивості
            as1.Kurs = 4;
            as1.zalikNumber = 39843;

            Aspirant as2 = new Aspirant("Petrov", 5, 50274, true);
            Aspirant as3 = new Aspirant("Sidorov", 5, 48274, true);

            as1.Print("as1");
            WriteLine("----------------------------");
            as2.Print("as2");
            WriteLine("----------------------------");
            as3.Print("as3");

            ReadKey();
        }
    }
}
