using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace ConsoleApp1
{
    internal class Program
    {
        class ArrayInt
        {
            private int[] A;
            private Random rnd = new Random();

            public ArrayInt(int size = 10)
            {


                A = new int[size];

                for (int i = 0; i < A.Length; i++)
                    A[i] = rnd.Next() % 10 + 1;
            }

            public void Print(string msg = "")
            {
                Write(msg + " => ");
                for (int i = 0; i < A.Length; i++)
                {
                    Write("{0} ", A[i]);
                }
                WriteLine();
            }

            public void SaveToFileBin(string filename)
            {
                using (
                    FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write)
                    )
                {

                    using (
                        BinaryWriter bw = new BinaryWriter(fs)
                    )
                    {
                        bw.Write(A.Length);

                        for (int i = 0; i < A.Length; i++)
                            bw.Write(A[i]);

                    }
                }
            }

            public void ReadFromFileBin(string filename)
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        int count = br.ReadInt32();

                        A = new int[count];

                        for (int i = 0; i < A.Length; i++)
                            A[i] = br.ReadInt32();

                    }
                }
            }

            public void SaveToFileTxt(string filename)
            {
                using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine("{0} ", A.Length);

                        for (int i = 0; i < A.Length; i++)
                            sw.WriteLine(A[i]);
                    }
                }
            }

            public void ReadFromFileTxt(string filename)
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        int count = ToInt32(sr.ReadLine());

                        A = new int[count];

                        for (int i = 0; i < A.Length; i++)
                            A[i] = ToInt32(sr.ReadLine());


                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] AI = { 2, 8, 7, 3, 4, 5, 19, 11, 17, 4 };

            IEnumerable<int> query = 
                from i in AI
                select i;

            WriteLine("AI:");
            foreach (int item in query)
                Write("{0}  ", item);

            WriteLine();

            WriteLine("Парні AI:");
            query =
                from i in AI
                where i % 2 == 0
                select i;

            foreach (int item in query)
                Write(item + "  ");
            WriteLine();

            //---------------------------------------
            query =
                from i in AI
                where i % 2 == 0
                orderby i 
                select i;
            WriteLine("Sorted AI:");
            foreach (int item in query)
                Write(item + "  ");
            WriteLine();

            //----------------------------------------
            IEnumerable<IGrouping<int,int>>
                query2 =
                from i in AI
                group i by i % 10;

            WriteLine();
            foreach (IGrouping<int,int> key in query2)
            {
                Write("Key:{0}\nValue:", key.Key);

                foreach (int value in key)
                    Write("\t{0}", value);
                WriteLine();
            }


            ReadKey();
        }
    }
}
