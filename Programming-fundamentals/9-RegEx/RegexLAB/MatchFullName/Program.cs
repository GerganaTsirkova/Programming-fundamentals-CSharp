using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            MatchCollection matches = Regex.Matches(input,pattern);

            foreach (Match matc in matches)
            {
                Console.Write(matc +" ");
            }
            Console.WriteLine();
        }
    }
}
