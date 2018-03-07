using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();
            List<long> quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<decimal> price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            string input = Console.ReadLine();
            while(input != "done")
            {
                for (int i = 0; i < names.Count; i++)
                {
                    if(input==names[i])
                    {
                        Console.WriteLine($"{input} costs: {price[i]}; Available quantity: {quantity[i]}");
                    }
                }
                input = Console.ReadLine();
            }
         }
    }
}
