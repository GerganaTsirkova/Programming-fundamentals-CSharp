using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            MatchCollection matches = Regex.Matches(input, pattern);
            string[] numbers = matches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
