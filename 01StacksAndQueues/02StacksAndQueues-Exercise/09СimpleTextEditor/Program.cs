using System;
using System.Collections.Generic;
using System.Linq;

namespace _09СimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = "";
            Stack<string> undoStack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split().ToArray();
                int command = int.Parse(commandArgs[0]);

                if (command == 1)
                {
                    undoStack.Push(text);
                    string textToAdd = commandArgs[1];
                    text += textToAdd;
                }
                else if (command == 2)
                {
                    undoStack.Push(text);
                    int count = int.Parse(commandArgs[1]);
                    //text = text.Substring(0, text.Length - count - 1);
                    int startIndex = text.Length - count;
                    text = text.Remove(startIndex);
                }
                else if (command == 3)
                {
                    int index = int.Parse(commandArgs[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (command == 4)
                {
                    text = undoStack.Pop();
                }
            }
        }
    }
}
