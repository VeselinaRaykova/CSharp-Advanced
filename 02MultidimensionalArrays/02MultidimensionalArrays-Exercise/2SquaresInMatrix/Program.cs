using System;
using System.Linq;

namespace _2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            char[,] matrix = new char[rows, cols];
            int squares = 0;

            for (int row = 0; row < rows; row++)
            {
                char[] elements = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray(); ;
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    char a = matrix[row, col];
                    char b = matrix[row, col + 1];
                    char c = matrix[row + 1, col];
                    char d = matrix[row + 1, col + 1];

                    if (a == b && b == c && c == d)
                    {
                        squares++;
                    }
                }
            }

            Console.WriteLine(squares);

        }
    }
}
