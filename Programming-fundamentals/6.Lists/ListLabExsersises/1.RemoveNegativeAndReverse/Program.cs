using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.RemoveNegativeAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numList.Count; i++)
            {
                if (numList[i] < 0)
                {
                    numList.RemoveAt(i);
                    i--;
                }
            }
            if(numList.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                numList.Reverse();
                Console.WriteLine(string.Join(" ", numList));
            }
        }
    }
}
