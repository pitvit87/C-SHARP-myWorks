using System;
using System.Dynamic;
using System.Threading;
using static System.Console;

namespace Yevtukh_KolomiietsC_DZ3
{
    class Enterprise // оголошуємо клас
    {
        public int codeEnterprise;
        public int codeProduct;
        public string nameProduct;
        public decimal price;
        public int count;

        // конструктор з 5 параметрами
        public Enterprise(int codeEnterprise, int codeProduct, string nameProduct, decimal price, int count) 
        {
            this.codeEnterprise = codeEnterprise;
            this.codeProduct = codeProduct;
            this.nameProduct = nameProduct;
            this.price = price;
            this.count = count;
        }

        public Enterprise() : this(0, 0, "", (decimal)0.0, 0) // конструктор за замовченням
        { }

        public int GetCodeEnterprise() { return codeEnterprise; } // Геттери
        public int GetCodeProduct() { return codeProduct; }
        public string GetNameProduct() { return nameProduct; }
        public decimal GetPrice() { return price; }
        public int GetCount() { return count; }
        public void SetCodeEnterprise(int codeEnterprise) { this.codeEnterprise = codeEnterprise; } // Сеттери
        public void SetCodeProduct(int codeProduct) { this.codeProduct = codeProduct; }
        public void SetNameProduct(string nameProduct) { this.nameProduct = nameProduct; }
        public void SetPrice(decimal price) { this.price = price; }
        public void SetCount(int count) { this.count = count; }

        public void Print(string msg) // вивід на єкран
        {
            WriteLine(msg + ":");
            WriteLine("Code entrprice: " + codeEnterprise);
            WriteLine("Code product: " + codeProduct);
            WriteLine("Name product: " + nameProduct);
            WriteLine("Price: {0:f2}", price);
            WriteLine("Count: " + count);

        }


        public void Input() // введення данних з клавіатури у поля класу по черзі
        {
                WriteLine("Input code enterprice:");
                this.codeEnterprise = int.Parse(ReadLine());
                WriteLine("Input code product:");
                this.codeProduct = int.Parse(ReadLine());
                WriteLine("Input name product:");
                this.nameProduct = ReadLine();
                WriteLine("Input price:");
                this.price = decimal.Parse(ReadLine());
                WriteLine("Input code count:");
                this.count = int.Parse(ReadLine());
        }

        public decimal GetCost() // дізнаемся вартість товару
        {
            return GetPrice() * GetCount();
        }


        public static decimal GetCostGlobal(Enterprise obj) // дізнаемося вартість товару статичнім методом класу
        {
            return obj.GetCount() * obj.GetPrice();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Enterprise en1 = new Enterprise(3456, 102,"Coca-Cola",(decimal)1.29,6); // тестуемо конструктор
            
            en1.Print("en1");
            WriteLine("------------------");

            WriteLine("GetCost() = " + en1.GetCost()); // тестуємо метод ГетКост()

            WriteLine("------------------");

            Enterprise en2 = new Enterprise(); // тестуемо геттери та сеттери
            en2.codeEnterprise = en1.codeEnterprise;
            en2.codeProduct = en1.codeProduct;
            en2.nameProduct = en1.nameProduct;
            en2.price = en1.price;
            en2.count = en1.count;

            en2.Print("en2");
            WriteLine("------------------");

            WriteLine("GetCostGlobal = " + Enterprise.GetCostGlobal(en2)); // тестуємо статичний метод ГетКостГлобал
            WriteLine("------------------");

            Enterprise en3 = new Enterprise();

            en3.Input(); // тестуємо метод введеня з клавіатури
            WriteLine("------------------");

            en3.Print("en3");
            WriteLine("------------------");

            WriteLine("GetCostGlobal = " + Enterprise.GetCostGlobal(en3));

            ReadKey();

        }
    }
}

