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

            public ArrayInt(int size = 10)
            {
                Random rnd = new Random();

                A = new int[size];

                for (int i = 0; i < A.Length; i++)
                    A[i] = rnd.Next() % 10 + 1;
            }

            public void Print(string msg = "")
            {
                Write(" => ");
                for (int i = 0; i < A.Length; i++)
                {
                    Write("{0} ", A[i]);
                }
                WriteLine();
            }

            public void SaveToFileBin(string filename)
            {
                FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
                
                    BinaryWriter bw = new BinaryWriter(fs);

                    bw.Write(A.Length);

                    for (int i = 0; i < A.Length; i++)
                        bw.Write(A[i]);

                    bw.Close();
                    fs.Close(); 
            }
        }

        static void Main(string[] args)
        {






            ReadKey();
        }
    }
}
