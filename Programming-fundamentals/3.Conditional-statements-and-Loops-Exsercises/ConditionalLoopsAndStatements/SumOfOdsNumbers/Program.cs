﻿using System;

namespace SumOfOdsNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < 2*n; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine("Sum: {0}",sum);
            
        }
    }
}
