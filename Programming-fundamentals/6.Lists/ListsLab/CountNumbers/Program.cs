using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int counter = 1;
            numbers.Sort();
            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    if (i == numbers.Count-2)
                    {
                        Console.WriteLine("{0} -> {1}", numbers[i], counter);
                        counter = 1;
                    }
                }
                else if ((i == numbers.Count - 2)&&(numbers[i] != numbers[i+1]))
                {
                    Console.WriteLine("{0} -> {1}", numbers[i], counter);
                    counter = 1;
                    i++;
                    Console.WriteLine("{0} -> {1}", numbers[i], counter);
                    break;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", numbers[i], counter);
                    counter = 1;
                }
                
            }

            
        }
    }
}
