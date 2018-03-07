using System;
using System.Linq;

namespace SortTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .OrderBy(x => x)
                .ToList();
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
