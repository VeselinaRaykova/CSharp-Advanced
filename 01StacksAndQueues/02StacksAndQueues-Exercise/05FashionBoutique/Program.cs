using System;
using System.Collections.Generic;
using System.Linq;

namespace _05FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(data);
            int sum = 0;
            int racks = 0;

            while (clothes.Any())
            {
                racks++;
                while (sum <= capacity && sum + clothes.Peek() <= capacity)
                {
                    sum += clothes.Pop();
                    if (!clothes.Any())
                    {
                        break;
                    }
                }

                sum = 0;
            }

            Console.WriteLine(racks);
        }
    }
}
