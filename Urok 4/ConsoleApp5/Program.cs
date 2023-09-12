using System;
using System.Collections.Generic;
using static System.Console;


namespace ConsoleApp1
{
    class Point
    {
        public class MatrixInt
        {
            int[,] M;

            public MatrixInt(uint m, uint n)
            {
                M = new int[m, n];

                for (int i = 0; i < M.GetLength(0); i++)
                    for (int j = 0; j < M.GetLength(1); j++)
                        M[i, j] = i * 2 + j * 2;
            }

            public int this[uint i, uint j]
            {
                get
                {
                    if (i >= M.GetLength(0))
                        throw new IndexOutOfRangeException();
                    return M[i, j];
                }
                set
                {
                    if (j >= M.GetLength(1))
                        throw new IndexOutOfRangeException();
                    M[i, j] = value;
                }
            }

            public int[] this[uint row]
            {
                get
                {
                    if (row >= M.GetLength(0))
                        throw new IndexOutOfRangeException();
                    int[] A = new int[M.GetLength(0)];
                    for (int i = 0; i < A.Length; i++)
                        A[i] = M[row, i];

                    return A;

                }
            }


        }


        internal class Program
        {
            static void Main(string[] args)
            {


                WriteLine("---------------------------");

                MatrixInt MI = new MatrixInt(3, 4);
                int t = MI[1, 2];
                WriteLine("t = " + t);

                int[] A = MI[2];
                for (int i = 0; i < A.Length; i++)
                    Write(A[i] + " ");
                WriteLine();

                ReadKey();
            }

        }
    }
}
