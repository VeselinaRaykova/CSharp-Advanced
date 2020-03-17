using System;
using System.Collections.Generic;

namespace _07SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            while (input != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    vip.Add(input);
                }
                else
                {
                    regular.Add(input);
                }

                input = Console.ReadLine();
            }

            while (input != "END")
            {
                vip.Remove(input);
                regular.Remove(input);

                input = Console.ReadLine();
            }

            Console.WriteLine(vip.Count + regular.Count);
            foreach (var guest in vip)
            {
                Console.WriteLine(guest);
            }
            foreach (var guest in regular)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
