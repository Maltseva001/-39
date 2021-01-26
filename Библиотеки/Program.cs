using System;

namespace Библиотеки
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[5, 8];
            int[] B = new int[8];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    A[i, j] = rnd.Next(-9, 9);
                    Console.Write("{0,5}", A[i, j]);
                }
                Console.WriteLine();
            }

            for (int j = 0; j < 8; j++)
            {
                B[j] = A[0, j];
                for (int i = 0; i < 5; i++)
                    if (A[i, j] < B[j])
                        B[j] = A[i, j];
            }

            Console.Write("\nМинимумы по столбцам:\n");
            for (int j = 0; j < 8; j++)
            {
                Console.Write("{0,5}", B[j]);
            }
            Console.Write("\nВектор:\n");
            for (int j = 7; j > -1; --j)
            {
                Console.Write("{0,5}", B[j]);
            }
            Console.ReadKey();
        }
    }
}
