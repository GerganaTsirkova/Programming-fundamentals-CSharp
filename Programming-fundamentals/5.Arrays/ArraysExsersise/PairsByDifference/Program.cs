using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                for (int j = i+1; j < arrayNumbers.Length; j++)
                {
                    if(Math.Abs(arrayNumbers[i]-arrayNumbers[j])==number)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
