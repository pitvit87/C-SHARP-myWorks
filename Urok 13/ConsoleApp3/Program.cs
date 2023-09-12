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

                        for (int i = 0; i<A.Length; i++)
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

            ArrayInt AI = new ArrayInt();

            AI.Print("AI");

            AI.SaveToFileBin("myfile.bin");
            ArrayInt AI2 = new ArrayInt();

            AI.Print("AI2");
            AI2.ReadFromFileBin("myfile.bin");
            AI2.Print("AI2+");
            AI.SaveToFileTxt("myfile.txt");
            ArrayInt AI3 = new ArrayInt();
            AI3.Print("AI3");
            AI3.ReadFromFileTxt("myfile.txt");
            AI3.Print("AI3+");


            


            ReadKey();
        }
    }
}
