using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _6.ValidUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', ',', '/', '\\', '(', ')' })
                .ToArray();
            string pattern = @"(^|(?<=\s))([A-Za-z])[\w]{2,24}";
            List<string> result = new List<string>();

            foreach (var member in input)
            {
                if(Regex.IsMatch(member,pattern)&&(member.Length>=3) &&(member.Length<=25))
                {
                    result.Add(member);
                }
            }
            
            int maxLen = 0;
            int len = 0;
            string first = "";
            string second = "";
            for (int i = 0; i < result.Count-1; i++)
            {
                len += result[i].Length + result[i+1].Length;
                if (maxLen < len)
                {
                    maxLen = result[i].Length + result[i+1].Length;
                    first = result[i];
                    second = result[i+1];
                }
                len = 0;
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
