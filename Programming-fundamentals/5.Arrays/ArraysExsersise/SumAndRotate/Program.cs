﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndRotate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sumArray = new int[arr.Length];

            for (int j = 1; j <= k; j++)
            {
                
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    arr[i] = arr[(i + k )% arr.Length];
                }
                
                for (int i = 0; i < arr.Length; i++)
                {
                    sumArray[i] += arr[i];
                }


            }
            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
