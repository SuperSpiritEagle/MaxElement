using System;
namespace MatrixElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 10;
            int col = 10;
            int[,] matrix = new int[row, col];
            int min = 1;
            int max = 1000;

            Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(min, max);
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > min)
                    {
                        min = matrix[i, j];
                    }
                }
            }

            Console.WriteLine($"Max element = {min} \n");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }

                Console.WriteLine("\n");
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == min)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }

                Console.WriteLine("\n");
            }
        }
    }
}
