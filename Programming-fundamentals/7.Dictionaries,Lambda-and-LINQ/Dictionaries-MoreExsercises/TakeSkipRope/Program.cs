using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            var nums = new List<int>();
            List<char> arr = input.
            for (int i = 0; i < arr.Count; i++)
            {
                if ((arr[i] >= 0) && (arr[i] <= 9))
                {
                    nums.Add(arr[i]);
                    arr.Remove(arr[i]);
                }
            }
        }
    }
}
