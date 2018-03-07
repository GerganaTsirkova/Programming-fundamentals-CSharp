using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine()
                .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while(command != "print")
            {
                var commandArgs = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if(commandArgs[0]=="add")
                {
                    num.Insert(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));//here we parse only what we need of the command
                }
                else if(commandArgs[0]=="addMany")
                {
                    num.InsertRange(int.Parse(commandArgs[1]),commandArgs.Skip(2).Select(int.Parse).ToList());
                }
                else if(commandArgs[0]=="contains")
                {
                    int number = int.Parse(commandArgs[1]);
                    if (num.Contains(number))
                    {
                        Console.WriteLine(num.IndexOf(number));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                 
                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(' ',num)}]");
        }
    }
}
