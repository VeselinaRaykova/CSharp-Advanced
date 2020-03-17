using System;
using System.Collections.Generic;
using System.Linq;

namespace _08BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> brackets = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char currBracket = input[i];
                if (currBracket == '{' || currBracket == '[' || currBracket == '(')
                {
                    brackets.Push(currBracket);
                }
                else
                {
                    if (!brackets.Any())
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    char prevBracket = brackets.Pop();

                    if ((prevBracket == '{' && currBracket == '}') ||
                        (prevBracket == '(' && currBracket == ')') ||
                        (prevBracket == '[' && currBracket == ']'))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }

            Console.WriteLine("YES");
        }
    }
}
