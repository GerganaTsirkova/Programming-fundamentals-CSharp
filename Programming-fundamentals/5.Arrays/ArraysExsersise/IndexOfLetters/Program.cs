using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach(char letter in input)
            {
                Console.WriteLine($"{letter} -> {letter-97}");
            }
        }
    }
}
