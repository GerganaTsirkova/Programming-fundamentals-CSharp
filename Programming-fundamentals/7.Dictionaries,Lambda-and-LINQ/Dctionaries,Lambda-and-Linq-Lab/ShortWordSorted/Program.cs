using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortWordSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine().ToLower();
            List<string> result = sentence
                .Split(new char[] { ',', ';', ' ', '.', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x)
                .Distinct()
                .ToList();

            for (int i = 0; i < result.Count; i++)
            {
                if(result[i].Length >= 5)
                {
                    result.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join(", ",result));
        }
    }
}
