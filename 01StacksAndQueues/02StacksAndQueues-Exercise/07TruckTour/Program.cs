using System;
using System.Collections.Generic;
using System.Linq;

namespace _07TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> petrolPumps = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] pump = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                petrolPumps.Enqueue(pump);
            }

            int index = 0;
            while (true)
            {
                int totalFuel = 0;

                foreach (var pump in petrolPumps)
                {
                    int petrol = pump[0];
                    int distance = pump[1];

                    totalFuel += petrol - distance;

                    if (totalFuel < 0)
                    {
                        index++;
                        petrolPumps.Enqueue(petrolPumps.Dequeue());
                        break;
                    }
                }

                if (totalFuel >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}
