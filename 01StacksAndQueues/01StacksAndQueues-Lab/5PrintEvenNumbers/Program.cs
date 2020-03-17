using System;
using System.Collections.Generic;
using System.Linq;

namespace _5PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> evenNumbers = new Queue<int>();
            List<int> result = new List<int>();

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Enqueue(num);
                }
            }

            while (evenNumbers.Count > 0)
            {
                result.Add(evenNumbers.Dequeue());
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
