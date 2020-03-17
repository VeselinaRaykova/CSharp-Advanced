using System;

namespace _7PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] matrix = new long[n][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new long[row + 1];

                for (int col = 0; col <= row; col++)
                {
                    if (col == 0)
                    {
                        matrix[row][col] = 1;
                    }
                    else if (col == matrix[row].Length - 1)
                    {
                        long a = matrix[row - 1][col - 1];
                        long b = 0;
                        matrix[row][col] = a + b;
                    }
                    else
                    {
                        long a = matrix[row - 1][col - 1];
                        long b = matrix[row - 1][col];
                        matrix[row][col] = a + b;
                    }
                }
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(long[][] matrix)
        {
            foreach (long[] row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
