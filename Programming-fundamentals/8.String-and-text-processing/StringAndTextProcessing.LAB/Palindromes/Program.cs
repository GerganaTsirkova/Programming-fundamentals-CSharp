using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ',', ' ', '.', '!', '?',':'}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<string> result = new List<string>();
            foreach (var word in input)
            {
                bool isPalindrome = IsPalindrome(word);
                if(isPalindrome)
                {
                    result.Add(word);
                }
            }
            result.Sort();
            Console.WriteLine(string.Join(", ",result));
        }
        public static bool IsPalindrome(string str)
        {
            return str.SequenceEqual(str.Reverse());
        }
    }
}
