using System;
using System.Linq;

namespace _5SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            int[,] matrix = new int[rows, cols];
            int currSum = 0;
            int maxSum = 0;

            int[,] maxSquare = new int[2, 2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int a = matrix[row, col];
                    int b = matrix[row, col + 1];
                    int c = matrix[row + 1, col];
                    int d = matrix[row + 1, col + 1];
                    currSum = a + b + c + d;

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxSquare = new int[2, 2] {
                            { a, b },
                            { c, d }
                        };
                    }
                }
            }

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write($"{maxSquare[row, col]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
