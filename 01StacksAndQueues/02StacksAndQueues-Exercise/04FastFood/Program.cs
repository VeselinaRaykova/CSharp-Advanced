using System;
using System.Collections.Generic;
using System.Linq;

namespace _04FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(input);

            Console.WriteLine(orders.Max());

            while (orders.Any() && foodQuantity >= orders.Peek())
            {
                foodQuantity -= orders.Dequeue();
            }

            if (orders.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders.ToArray())}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
