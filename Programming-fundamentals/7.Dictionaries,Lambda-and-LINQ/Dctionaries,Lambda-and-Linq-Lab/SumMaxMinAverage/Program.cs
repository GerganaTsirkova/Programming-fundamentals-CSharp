using System;
using System.Collections.Generic;
using System.Linq;

namespace SumMaxMinAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> num = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                num.Add(number);
            }

            Console.WriteLine("Sum = {0}",num.Sum());
            Console.WriteLine("Min = {0}",num.Min());
            Console.WriteLine("Max = {0}",num.Max());
            Console.WriteLine($"Average = {num.Average()}");
        }
    }
}
