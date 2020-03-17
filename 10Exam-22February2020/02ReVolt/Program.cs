using System;

namespace _02ReVolt
{
    class Program
    {
        public static int targetRow = -1;
        public static int targetCol = -1;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int playerRow = -1;
            int playerCol = -1;

            bool isWinner = false;

            for (int row = 0; row < n; row++)
            {
                char[] elements = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    if (elements[col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }

                    matrix[row, col] = elements[col];
                }
            }

            for (int i = 0; i < count; i++)
            {
                string direction = Console.ReadLine();
                GetTargetCell(direction, n, playerRow, playerCol);

                char targetCell = matrix[targetRow, targetCol];

                while (targetCell != '-' && targetCell != 'F')
                {
                    if (targetCell == 'B')
                    {
                        GetTargetCell(direction, n, targetRow, targetCol);
                        targetCell = matrix[targetRow, targetCol];
                    }
                    else if (targetCell == 'T')
                    {
                        targetRow = playerRow;
                        targetCol = playerCol;
                        targetCell = matrix[targetRow, targetCol];
                        break;
                    }
                }

                matrix[playerRow, playerCol] = '-';
                matrix[targetRow, targetCol] = 'f';

                if (targetCell == 'F')
                {
                    isWinner = true;
                    break;
                }

                playerRow = targetRow;
                playerCol = targetCol;
            }

            if (isWinner)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            PrintMatrix(matrix);
        }

        private static void GetTargetCell(string direction, int n, int row, int col)
        {
            if (direction == "up")
            {
                targetRow = row - 1 >= 0 ? row - 1 : row - 1 + n;
                targetCol = col;
            }
            else if (direction == "down")
            {
                targetRow = row + 1 < n ? row + 1 : row + 1 - n;
                targetCol = col;
            }
            else if (direction == "left")
            {
                targetRow = row;
                targetCol = col - 1 >= 0 ? col - 1 : col - 1 + n;
            }
            else if (direction == "right")
            {
                targetRow = row;
                targetCol = col + 1 < n ? col + 1 : col + 1 - n;
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
