﻿using System;
using System.Text.RegularExpressions;

namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var numbers = Regex.Matches(input, pattern);
            foreach (Match num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
