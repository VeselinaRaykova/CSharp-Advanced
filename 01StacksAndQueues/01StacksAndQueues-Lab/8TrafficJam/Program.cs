using System;
using System.Collections.Generic;

namespace _8TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int passed = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passed++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{passed} cars passed the crossroads.");
        }
    }
}
