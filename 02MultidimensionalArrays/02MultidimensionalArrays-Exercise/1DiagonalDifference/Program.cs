using System;
using System.Linq;

namespace _1DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int row = 0; row < n; row++)
            {
                matrix[row] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); ;
            }

            for (int row = 0; row < n; row++)
            {
                primaryDiagonal += matrix[row][row];
                secondaryDiagonal += matrix[row][n - row - 1];
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}
