using System;
namespace MatrixElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixRow = 10;
            int matrixColumn = 10;
            int[,] matrixNumbers = new int[matrixRow, matrixColumn];
            int minNumber = -1000;
            int maxNumber = 0;
            int maxElement = int.MinValue;
            int replacedByNumber = 0;

            Random random = new Random();

            for (int i = 0; i < matrixNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers.GetLength(1); j++)
                {
                    matrixNumbers[i, j] = random.Next(minNumber, maxNumber);
                }
            }

            for (int i = 0; i < matrixNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers.GetLength(1); j++)
                {
                    if (matrixNumbers[i, j] > maxElement)
                    {
                        maxElement = matrixNumbers[i, j];
                    }
                }
            }

            Console.WriteLine($"Max element = {maxElement} \n");

            for (int i = 0; i < matrixNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers.GetLength(1); j++)
                {
                    Console.Write(matrixNumbers[i, j] + "\t");
                }

                Console.WriteLine("\n");
            }

            for (int i = 0; i < matrixNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers.GetLength(1); j++)
                {
                    if (matrixNumbers[i, j] == maxElement)
                    {
                        matrixNumbers[i, j] = replacedByNumber;
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < matrixNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers.GetLength(1); j++)
                {
                    Console.Write(matrixNumbers[i, j] + "\t");
                }

                Console.WriteLine("\n");
            }
        }
    }
}
