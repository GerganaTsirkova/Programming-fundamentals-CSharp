using System;
using System.Linq;

namespace ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int minimal = arr.Min();
            int maximal = arr.Max();
            int sum = arr.Sum();
            double average = arr.Average();

            Console.WriteLine("Min = {0}", minimal);
            Console.WriteLine("Max = {0}", maximal);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", average);
        }
        

        
    }
}
