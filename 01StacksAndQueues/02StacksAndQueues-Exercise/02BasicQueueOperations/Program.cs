using System;
using System.Collections.Generic;
using System.Linq;

namespace _02BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commandArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int toAdd = commandArgs[0];
            int toRemove = commandArgs[1];
            int toSearch = commandArgs[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers.Take(toAdd));

            for (int i = 0; i < toRemove; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(toSearch))
            {
                Console.WriteLine("true");
            }
            else if (queue.Any())
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
