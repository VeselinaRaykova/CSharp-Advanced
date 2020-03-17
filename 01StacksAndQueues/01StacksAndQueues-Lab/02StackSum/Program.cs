using System;
using System.Collections.Generic;
using System.Linq;

namespace _02StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            int sum = 0;

            foreach (int num in numbers)
            {
                stack.Push(num);
            }

            string[] commandArgs = Console.ReadLine().Split().ToArray();

            while (commandArgs[0].ToLower() != "end")
            {
                string command = commandArgs[0].ToLower();

                if (command == "add")
                {
                    int num1 = int.Parse(commandArgs[1]);
                    int num2 = int.Parse(commandArgs[2]);
                    stack.Push(num1);
                    stack.Push(num2);
                }
                else if (command == "remove")
                {
                    int n = int.Parse(commandArgs[1]);

                    if (n < stack.Count)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                commandArgs = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
