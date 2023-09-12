using System;
using static System.Console;

namespace ConsoleApp1
{
    class Human // базовий клас
    {
        protected string surname;
        protected string name;
        protected int year;
        protected int month;
        protected int day;
        protected DateTime birthDate;
    
        public Human(string surname, string name, int year, int month, int day) // конструктор з п'ятью параметрами
        {
            this.surname = surname;
            this.name = name;
            this.birthDate = new DateTime(year, month, day);
        }

        public Human() : this("","",0001,01,01) // конструктор за замовченням
        { }

        public void Info(string msg) // вивід на єкран
        {
            WriteLine(msg+":");
            WriteLine("Surname: " + surname);
            WriteLine("Name: " + name);
            WriteLine("Birth Date: " + birthDate);

        }
        public string Surname // Геттери - Сеттери
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Day
        {
            get { return day; }
            set { day = value; }
        }


    }

    class Citizen : Human // клас що успадковує базовий
    {
        protected string passportNumber;
        protected string address;
    
        public Citizen(string surname, string name, int year, int month, int day, string passportNumber,
            string address) : base(surname, name, year, month, day) // конструктор з сім'ю параметрами, що успадковує
                                                                    // 5 параметрів
        {
            this.passportNumber = passportNumber;
            this.address = address;
        }

        public Citizen() : this("", "", 0001, 01, 01, "", "") // конструктор за замовченням
        { }

        public new void Info(string msg) // вивід на єкран з успадковунням попередньої фукції Инфо()
        {
            base.Info(msg);
            WriteLine("Passport Number: " + passportNumber);
            WriteLine("Address: " + address);
        }

        public string PassportNumber // Геттери - Сеттери
        {
            get { return passportNumber; }
            set { passportNumber = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

    }

    class ForeignCitizen : Citizen // класс, який успадковує попередній
    {
        protected string foreignPassportNumber;
    
        public ForeignCitizen(string surname, string name, int year, int month, int day, string passportNumber, 
            string address, string foreignPassportNumber) : base (surname, name, year, month, day, passportNumber,
                address) // конструктор з вісімью параметрами, що успадковує сім з базового класу
        {
            this.foreignPassportNumber = foreignPassportNumber;
        }

        public ForeignCitizen() : this("", "", 0001, 01, 01, "", "", "") // конструктор за замовченням 
        { }

        public new void Info(string msg) //Вивід на єкран, що успадковіє вивід на єкран з базового класу
        {
            base.Info (msg);
            WriteLine("Foreign Passport Number: " + foreignPassportNumber);
        }

        public string ForeignPassportNumber // геттери - сеттери
        {
            get { return foreignPassportNumber; }
            set { foreignPassportNumber = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ForeignCitizen person = new ForeignCitizen("Ivanov", "Ivan", 1978, 05, 12, "DF 657 435", "USA, California," +
                " Beverly Hills 90210", "FT 345 765");
            person.Info("Person");

            ReadKey();
        }
    }
}
