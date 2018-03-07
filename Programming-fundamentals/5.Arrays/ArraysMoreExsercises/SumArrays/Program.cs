using System;
using System.Linq;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] second = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] sumArray = new int[Math.Max(first.Length, second.Length)];

            for (int i = 0; i < sumArray.Length; i++)
            {
                if(first.Length>second.Length)
                {
                    sumArray[i] = first[i] + second[i % second.Length];
                }
                else
                {
                    sumArray[i] = first[i%first.Length] + second[i];
                }
            }
            Console.WriteLine(string.Join(" ",sumArray));
        }
    }
}
