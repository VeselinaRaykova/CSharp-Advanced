using System;
using System.Collections.Generic;
using System.Linq;

namespace _03SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Stack<string> stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                int num1 = int.Parse(stack.Pop());
                string function = stack.Pop();
                int num2 = int.Parse(stack.Pop());
                int result = function == "+" ? num1 + num2 : num1 - num2;

                stack.Push(result.ToString());
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
