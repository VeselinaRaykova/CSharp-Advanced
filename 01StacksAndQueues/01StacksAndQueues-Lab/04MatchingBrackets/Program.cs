using System;
using System.Collections.Generic;

namespace _04MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); //1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
            Stack<int> indexes = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    int start = indexes.Pop();
                    int end = i;
                    Console.WriteLine(input.Substring(start, end - start + 1));
                }
            }
        }
    }
}
