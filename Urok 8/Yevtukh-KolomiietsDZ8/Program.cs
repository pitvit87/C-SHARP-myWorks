using System;
using static System.Console;

namespace Yevtukh_KolomiietsDZ8
{
    class Human // створюємо клас Х'юман
    {
        private string name; // приховані поля
        private string surname;
        
        public Human(string name, string surname) // конструктор з 2 параметрами
        {
            this.name = name;
            this.surname = surname;
        }

        public Human() : this("","") // конструктор за замовченням
        { }

        public string Name // геттери сеттери
        { get; set; }

        public string Surname
        { get; set; }

        public virtual void Print(string msg) //вивід на єкран полиморфним методом
        {
            WriteLine(msg + ":");
            WriteLine(name + " " + surname);
        }

    }

    class Worker : Human // класс Воркер, що наслідує Хуман
    {
        private DateTime employmentDate; // поля класа
        private string position;

        public Worker(string name, string surname, int year, int month, int day, string position) 
            : base(name, surname) // конструктор з параметрами 
        {
            this.employmentDate = new DateTime(year,month,day);
            this.position = position;
        }

        public Worker() : this("","",1970,01,01,"") // конструктор за замовченням
        { }

        public int Year // геттери сеттери
        { set; get; }
        public int Month
        { set; get; }
        public int Day
        { set; get; }
        public DateTime EmploymentDate
        {
            get { return employmentDate; }
            set { employmentDate = new DateTime(Year, Month, Day); }
        }

        public override void Print(string msg) // вивід на єкран
        {
            base.Print(msg);
            WriteLine("Employment Date: " + employmentDate);
            WriteLine("Position: " + position);
        }
    }

    class Manager : Worker // клас Менеджер
    {
        private int numPeople; // поле

        public Manager(string name, string surname, int year, int month, int day, string position, int numPeople)
            : base(name, surname, year, month, day, position) // конструктор з параметрами
        { 
            this.numPeople = numPeople;
        }

        public Manager() : this("","",1970,01,01,"",0) // конструктор за замовченням
        { }

        public int NumPeople // геттери сеттери
        { 
            get { return numPeople; }
            set { numPeople = value; }
        }

        public override void Print(string msg) // вивід на єкран поліморфним методом
        {
            base.Print(msg);
            WriteLine("Number People: " + numPeople);
        }

    }

    class Demo // клас Демо
    {
        
        
        public void PrintData(Human refH) // метод ПринтДата
        {
            refH.Print("Demo");
        }
    }

    internal class Program
    {
       

        static void Main(string[] args)
        {
            Manager manager1 = new Manager("Ivan","Ivanov",2018,03,12,"Boss",43);
            manager1.Print("manager1");
            WriteLine("-----------------------");

            Human human = new Human("Petr", "Petrov");

            Human refA;
            refA = human;

            Demo demo = new Demo();
            demo.PrintData(refA);

            ReadKey();
        }
    }
}
