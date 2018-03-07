﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjustmentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            for (int i = 1; i < numbers.Count; i++)
            {
                if(numbers[i-1]==numbers[i])
                {
                    numbers[i - 1] = 2 * numbers[i - 1];
                    numbers.Remove(numbers[i]);
                    i--;
                    if (i >= 1)
                    {
                        i--;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
