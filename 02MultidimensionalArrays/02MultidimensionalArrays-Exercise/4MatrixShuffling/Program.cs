using System;
using System.Linq;

namespace _4MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string[,] matrix = FillMatrix(size);

            string[] commandArgs = Console.ReadLine().Split(" ").ToArray();
            while (commandArgs[0] != "END")
            {
                string command = commandArgs[0];

                if (command == "swap")
                {
                    int row1 = int.Parse(commandArgs[1]);
                    int col1 = int.Parse(commandArgs[2]);

                    int row2 = int.Parse(commandArgs[3]);
                    int col2 = int.Parse(commandArgs[4]);

                    bool areValid = ValidateCoords(commandArgs.Skip(1).Select(int.Parse).ToArray(), matrix.GetLength(0), matrix.GetLength(1));

                    if (areValid)
                    {
                        string temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;
                        PrintMatrix(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                commandArgs = Console.ReadLine().Split(" ").ToArray();
            }
        }

        private static string[,] FillMatrix(int[] size)
        {
            int rows = size[0];
            int cols = size[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] elements = Console.ReadLine().Split(" ").ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            return matrix;
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool ValidateCoords(int[] coords, int rows, int cols)
        {
            if (coords.Length != 4 ||
                coords[0] < 0 || coords[1] < 0 || coords[2] < 0 || coords[3] < 0 ||
                coords[0] > rows || coords[1] > cols || coords[2] > rows || coords[3] > cols
                )
            {
                return false;
            }

            return true;
        }
    }
}
