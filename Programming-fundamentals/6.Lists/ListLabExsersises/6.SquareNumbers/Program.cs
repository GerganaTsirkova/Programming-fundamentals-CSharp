using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> num = new List<int>();
            foreach (var n in numbers)
            {
                if(Math.Sqrt(n) == (int)Math.Sqrt(n))
                {
                    num.Add(n);
                }
            }
            num.Sort();
            num.Reverse();
            Console.WriteLine(string.Join(" ",num));
        }
    }
}
