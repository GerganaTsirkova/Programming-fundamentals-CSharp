using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int digit;
            bool parsedString = int.TryParse(input, out digit);
            if(parsedString==true)
                Console.WriteLine("digit");
            else if (input=="a"||input=="e"|| input == "i" || input == "o" || input == "u" || input == "y")
                Console.WriteLine("vowel");
            else
                Console.WriteLine("other");

        }
    }
}
