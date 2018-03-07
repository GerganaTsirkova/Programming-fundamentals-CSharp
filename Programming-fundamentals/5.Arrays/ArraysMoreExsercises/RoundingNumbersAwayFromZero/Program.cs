using System;
using System.Linq;

namespace RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                int result = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}",arr[i],result);
            }

        }
    }
}
