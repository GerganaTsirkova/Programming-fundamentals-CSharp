using System;
using System.Collections.Generic;
using System.Linq;

namespace OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            nums.RemoveAll(x => x % 2 != 0);
            int ave = (int)nums.Average();
            for (int i = 0; i < nums.Count; i++)
            {
                if(nums[i]<=ave)
                {
                    nums[i] -= 1;
                }
                else
                {
                    nums[i] += 1;
                }
            }
            Console.WriteLine(string.Join(" ",nums));
        }

        
    }
}
