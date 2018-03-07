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
                if ((numbers[i - 1] == numbers[i]) && (i >= 1))
                {
                    numbers[i] *= 2;
                    numbers.RemoveAt(i - 1);
                    if (i >= 2)
                    {
                        i -= 2;
                    }
                    else if (i >= 1)
                    {
                        i--;
                    }
                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}