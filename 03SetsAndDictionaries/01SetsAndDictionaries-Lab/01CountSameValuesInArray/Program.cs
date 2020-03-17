using System;
using System.Collections.Generic;
using System.Linq;

namespace _01CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Dictionary<double, int> counter = new Dictionary<double, int>();

            foreach (double num in numbers)
            {
                if (!counter.ContainsKey(num))
                {
                    counter.Add(num, 0);
                }
                counter[num]++;
            }

            foreach (var pair in counter)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }
        }
    }
}
