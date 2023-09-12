using System;
using static System.Console;
using System.Deployment.Internal;

namespace ConsoleApp1
{
    public class A
    {
        private int private_A;
        protected int protected_A;
        public int public_A;

        internal int internal_A;
        private protected int private_protected_A;
        protected internal int protected_internal_A;
    }

    public class B : A
    {
        public void Method()
        {
            //private_A = 10;
            protected_A = 10;
            public_A = 20;

            internal_A = 40;
            private_protected_A = 50;
            protected_internal_A = 60;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            B objB = new B();
            objB.public_A = 30;
        }
    }
}
