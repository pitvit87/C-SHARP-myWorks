using System;
using System.Runtime.InteropServices;
using System.Threading;
using static System.Console;
using static System.Enum;

namespace ConsoleApp1
{
    enum Countries
    {
        USA = 1,
        Ukraine = 380,
        Australia = 61,
        Mexico = 52,
        Germany = 49
    };
    struct Subscriber
    {
        private string name;
        private string phoneNumber;
        private string address;
        private Countries code;
        
        public Subscriber(string name, string phoneNumber, string address, Countries code)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.code = code;
        }

        public void Print(string msg)
        {
            WriteLine(msg + " => ");
            WriteLine("Name: " + name);
            WriteLine("Phone Number: " + phoneNumber);
            WriteLine("Address: " + address);
            WriteLine("Code: " + code);
        }

        public void Input()
        {
            WriteLine("Enter name: ");
            name = ReadLine();

            WriteLine("Enter phone number: ");
            phoneNumber = ReadLine();

            WriteLine("Enter address: ");
            address = ReadLine();
            
            WriteLine("Enter code: ");
            string codeInput = ReadLine();
            if (Enum.TryParse(codeInput, out Countries countryCode) && Enum.IsDefined(typeof(Countries), countryCode))
            {
                code = countryCode;
            }
            else
            {
                code = Countries.USA;
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public Countries Code
        {
            get { return code; }
            set
            {
                if (Enum.IsDefined(typeof(Countries), value))
                {
                    code = value;
                }
                else
                {
                    code = Countries.USA;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Subscriber subscriber = new Subscriber();
            subscriber.Input();

            WriteLine("Subscriber info:");
            subscriber.Print("Subscriber");

            ReadKey();
        }
    }
}
