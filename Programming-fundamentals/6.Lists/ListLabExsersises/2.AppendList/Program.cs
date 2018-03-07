using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SumAdjustEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 1; i < numbers.Count; i++)
            {
                if ((numbers[i] == numbers[i - 1])&&(i>=1))
                {
                    numbers.RemoveAt(i);
                    numbers[i - 1] *= 2;
                    
                    i--;
                }
                Console.WriteLine(string.Join(' ', numbers));
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
