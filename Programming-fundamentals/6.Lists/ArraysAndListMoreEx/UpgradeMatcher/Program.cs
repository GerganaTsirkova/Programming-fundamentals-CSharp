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
            List<decimal> quantity = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            List<decimal> price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            decimal currentQ = 0;
            List<string> input = Console.ReadLine().Split(' ').ToList();
            for (int i = quantity.Count; i < names.Count; i++)
            {
                quantity.Add(0);
            }
            while (input[0] != "done")
            {
                for (int i = 0; i < names.Count; i++)
                {
                    if (input[0] == names[i])
                    {
                        currentQ = decimal.Parse(input[1]);
                        if (currentQ <= quantity[i])
                        {
                            Console.WriteLine("{0} x {1} costs {2:f2}", input[0], input[1], price[i] * currentQ);
                            quantity[i] -= currentQ;
                        }
                        else
                        {
                            Console.WriteLine("We do not have enough {0}", names[i]);
                            break;
                        }
                        
                    }

                }
                input = Console.ReadLine().Split(' ').ToList();
            }
            
        }
    }
}
