using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numbers.Sort();
            int counter = 1;
            if (numbers.Count==1)
            {
                Console.WriteLine($"{numbers[0]} -> {counter}");
            }
             else
            {
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        counter++;
                        if (i == numbers.Count - 2)
                        {
                            Console.WriteLine($"{numbers[numbers.Count - 2]} -> {counter}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{numbers[i]} -> {counter}");
                        counter = 1;
                        if (i == numbers.Count - 2)
                        {
                            Console.WriteLine($"{numbers[numbers.Count - 1]} -> {counter}");
                        }
                    }
                }


            }
        }
    }
}
