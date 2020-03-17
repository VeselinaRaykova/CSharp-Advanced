using System;
using System.Collections.Generic;
using System.Linq;

namespace _5SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];

            char[] snakeText = Console.ReadLine().ToCharArray();
            Queue<char> snake = new Queue<char>(snakeText);
            char[,] isle = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        isle[row, col] = snake.Dequeue();
                        snake.Enqueue(isle[row, col]);
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        isle[row, col] = snake.Dequeue();
                        snake.Enqueue(isle[row, col]);
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(isle[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
