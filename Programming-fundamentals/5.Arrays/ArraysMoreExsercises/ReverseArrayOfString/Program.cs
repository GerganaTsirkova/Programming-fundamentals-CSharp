using System;
using System.Linq;

namespace ReverseArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] {' ' },StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Array.Reverse(input);
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
