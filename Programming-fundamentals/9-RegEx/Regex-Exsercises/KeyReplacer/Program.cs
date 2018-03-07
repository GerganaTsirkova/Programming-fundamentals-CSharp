using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Za-z]+)([<\|\\])(.*)([<\|\\])([A-Za-z]+)";
            string input = Console.ReadLine();
            Match mymach = Regex.Match(input, pattern);
            string start = mymach.Groups[1].Value;
            string end = mymach.Groups[5].Value;
            string input2 = Console.ReadLine();
            string pattern2 = $"{start}(.*?){end}";
            StringBuilder builder = new StringBuilder();
            MatchCollection result = Regex.Matches(input2, pattern2);
            foreach (Match item in result)
            {
                builder.Append(item.Groups[1].Value);
            }
            if(builder.Length==0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(builder);
            }
        }
    }
}
