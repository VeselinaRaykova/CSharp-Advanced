using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MaximumAndMinimumElement
{
    class Program
    {
        public static Stack<int> numbers = new Stack<int>();

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] commandArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int type = commandArgs[0];

                switch (type)
                {
                    case 1:
                        numbers.Push(commandArgs[1]);
                        break;
                    case 2:
                        if (numbers.Any())
                        {
                            numbers.Pop();
                        }
                        break;
                    case 3:
                        if (numbers.Any())
                        {
                            Console.WriteLine(numbers.Max());
                        }
                        break;
                    case 4:
                        if (numbers.Any())
                        {
                            Console.WriteLine(numbers.Min());
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers.ToArray()));
        }
    }
}
