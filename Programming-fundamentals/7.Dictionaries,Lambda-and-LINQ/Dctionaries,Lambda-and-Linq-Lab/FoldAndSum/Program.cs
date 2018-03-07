using System;
using System.Collections.Generic;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = num.Length / 4;
            int[] left = num.Take(k).Reverse().ToArray();
            int[] right = num.Reverse().Take(k).ToArray();
            int[] firstRow = left.Concat(right).ToArray();
            int[] secondRow = num.Skip(k).Take(2 * k).ToArray();
            var result = firstRow.Select((x,index) => (x+secondRow[index]));
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
