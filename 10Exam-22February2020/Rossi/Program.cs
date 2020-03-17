using System;
using System.Collections.Generic;
using System.Linq;

namespace Re_Volt_EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int countCommands = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int rowPlayer = 0;
            int colPlayer = 0;

            for (int r = 0; r < size; r++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                for (int c = 0; c < size; c++)
                {
                    if (currentRow[c] == 'f')
                    {
                        rowPlayer = r;
                        colPlayer = c;
                    }
                    matrix[r, c] = currentRow[c];
                }
            }

            matrix[rowPlayer, colPlayer] = '-';

            for (int i = 0; i < countCommands; i++)
            {
                string command = Console.ReadLine();

                switch (command)
                {
                    case "up": rowPlayer--; break;
                    case "down": rowPlayer++; break;
                    case "left": colPlayer--; break;
                    case "right": colPlayer++; break;

                    default:
                        break;
                }

                Tuple<int, int> positionsPlayer = CheckPlayerBoundary(size, rowPlayer, colPlayer);
                rowPlayer = positionsPlayer.Item1;
                colPlayer = positionsPlayer.Item2;

                if (matrix[rowPlayer, colPlayer] == 'F')
                {
                    matrix[rowPlayer, colPlayer] = 'f';
                    Console.WriteLine("Player won!");

                    for (int r = 0; r < size; r++)
                    {
                        for (int c = 0; c < size; c++)
                        {
                            Console.Write(matrix[r, c]);
                        }

                        Console.WriteLine();
                    }
                    return;
                }
                else if (matrix[rowPlayer, colPlayer] == 'B')
                {

                    switch (command)
                    {
                        case "up": rowPlayer--; break;
                        case "down": rowPlayer++; break;
                        case "left": colPlayer--; break;
                        case "right": colPlayer++; break;

                        default:
                            break;
                    }
                    Tuple<int, int> newPositionsPlayer = CheckPlayerBoundary(size, rowPlayer, colPlayer);
                    rowPlayer = newPositionsPlayer.Item1;
                    colPlayer = newPositionsPlayer.Item2;

                }
                else if (matrix[rowPlayer, colPlayer] == 'T')
                {
                    switch (command)
                    {
                        case "up": rowPlayer--; break;
                        case "down": rowPlayer++; break;
                        case "left": colPlayer--; break;
                        case "right": colPlayer++; break;

                        default:
                            break;
                    }
                    Tuple<int, int> newPositionsPlayer = CheckPlayerBoundary(size, rowPlayer, colPlayer);
                    rowPlayer = newPositionsPlayer.Item1;
                    colPlayer = newPositionsPlayer.Item2;
                }
            }

            Console.WriteLine("Player lost!");
            matrix[rowPlayer, colPlayer] = 'f';
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    Console.Write(matrix[r, c]);
                }

                Console.WriteLine();
            }
            return;


        }

        public static Tuple<int, int> CheckPlayerBoundary(int size, int row, int column)
        {
            if (row < 0)

            {
                row = size - 1;
                return Tuple.Create(row, column);
            }
            else if (row >= size)
            {
                row = 0;
                return Tuple.Create(row, column);
            }
            else if (column < 0)
            {
                column = size - 1;
                return Tuple.Create(row, column);
            }
            else if (column >= size)
            {
                column = 0;
                return Tuple.Create(row, column);
            }
            else
            {
                return Tuple.Create(row, column);
            }


        }
    }
}