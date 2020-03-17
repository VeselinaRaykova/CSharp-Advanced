using System;
using System.Linq;

namespace _6JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = ReadMatrix();
            string[] commandArgs = Console.ReadLine().Split().ToArray();

            while (commandArgs[0] != "END")
            {
                string command = commandArgs[0];
                int row = int.Parse(commandArgs[1]);
                int col = int.Parse(commandArgs[2]);
                int value = int.Parse(commandArgs[3]);
                if (row < 0 || row > matrix.GetLength(0) || col < 0 || col > matrix[0].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (command == "Add")
                {
                    matrix[row][col] += value;
                }
                else if (command == "Subtract")
                {
                    matrix[row][col] -= value;
                }

                commandArgs = Console.ReadLine().Split().ToArray();
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[][] matrix)
        {
            foreach (int[] row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static int[][] ReadMatrix()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];

            for (int row = 0; row < n; row++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row] = elements;
                }
            }

            return matrix;
        }
    }
}
