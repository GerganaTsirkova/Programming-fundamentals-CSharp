using System;
using System.Linq;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            bool exist = false;
            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                for (int j = i+1; j < arr.Length; j++)
                {
                    sum = arr[i] + arr[j];
                    for (int k = 0; k < arr.Length; k++)
                    {
                        if(sum==arr[k])
                        {
                            Console.WriteLine($"{arr[i]} + {arr[j]} == {arr[k]} ");
                            exist = true;
                        }
                    }
                }
            }
            if(!exist)
            {
                Console.WriteLine("No");
            }
        }
    }
}
