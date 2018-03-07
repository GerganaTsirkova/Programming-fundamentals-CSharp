using System;
using System.Linq;

namespace ExtractMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            if(nums.Length==1)
            {
                Console.WriteLine("{{ {0} }}",nums[0]);
            }
            else if (nums.Length % 2 == 0)
            {
                Console.WriteLine("{{ {0}, {1} }}",nums[nums.Length/2-1],nums[nums.Length/2]);
            }
            else if(nums.Length % 2 !=0)
            {
                Console.WriteLine("{{ {0}, {1}, {2} }}", nums[nums.Length / 2 - 1], nums[nums.Length / 2], nums[nums.Length/2+1]);
            }
        }
    }
}
