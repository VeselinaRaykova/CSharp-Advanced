using System;
using System.Collections.Generic;
using System.Linq;

namespace _01BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commandArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int toPush = commandArgs[0];
            int toPop = commandArgs[1];
            int toSearch = commandArgs[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers.Take(toPush));
            for (int i = 0; i < toPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(toSearch))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
