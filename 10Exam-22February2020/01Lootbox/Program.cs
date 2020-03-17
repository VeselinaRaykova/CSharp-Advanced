using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> firstLootBox = new Queue<int>(input);

            input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> secondLootBox = new Stack<int>(input);
            Stack<int> claimedItems = new Stack<int>();
            int claimedSum = 0;

            while (firstLootBox.Any() && secondLootBox.Any())
            {
                int sum = firstLootBox.Peek() + secondLootBox.Peek();
                if (sum % 2 == 0)
                {
                    claimedItems.Push(sum);
                    firstLootBox.Dequeue();
                    secondLootBox.Pop();
                }
                else
                {
                    firstLootBox.Enqueue(secondLootBox.Pop());
                }
            }

            if (!firstLootBox.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (!secondLootBox.Any())
            {
                Console.WriteLine("Second lootbox is empty");
            }

            claimedSum = claimedItems.Sum();
            if (claimedSum > 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedSum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedSum}");
            }
        }
    }
}
