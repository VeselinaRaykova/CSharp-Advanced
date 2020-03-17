using System;
using System.Collections.Generic;

namespace _6Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Queue<string> people = new Queue<string>();

            while (true)
            {
                if (name == "End")
                {
                    break;
                }
                else if (name == "Paid")
                {
                    while (people.Count > 0)
                    {
                        Console.WriteLine(people.Dequeue());
                    }
                }
                else
                {
                    people.Enqueue(name);
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}
