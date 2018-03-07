using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.SplitByWord
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] { ',', ';', ' ', '.', ':', '!', '(', ')','"', '\'', '\\', '/', '[', ']' },StringSplitOptions.RemoveEmptyEntries)
                .ToList();
    
            List<string> lower = new List<string>();
            List<string> upper = new List<string>();
            List<string> mixed = new List<string>();
            foreach (string word in input)
            {
                if (word.All(char.IsUpper))
                {
                    upper.Add(word);
                    
                }
                else if (word.All(char.IsLower))
                {
                    lower.Add(word);
                    
                }
                else
                {
                    mixed.Add(word);
                    
                }
            }
            
            Console.Write("Lower-case: ");
            Console.WriteLine(string.Join(", ", lower));
            Console.Write("Mixed-case: ");
            Console.WriteLine(string.Join(", ", mixed));
            Console.Write("Upper-case: ");
            Console.WriteLine(string.Join(", ", upper));
            
        }

    }
}
