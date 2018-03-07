using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}";
            MatchCollection match = Regex.Matches(input,pattern);
            string[] phones = match
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ",phones));
        }
    }
}
