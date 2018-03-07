using System;
using System.Collections.Generic;
using System.Linq;

namespace ByteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            List<string> result = new List<string>();
            foreach (var signs in input)
            {
                if(signs.Length != 2)
                {
                    continue;
                }
                else
                {
                    char[] arr = signs.ToCharArray();
                    Array.Reverse(arr);
                    string reversedNums = arr[0].ToString() + arr[1].ToString();
                    result.Add(reversedNums);
                }
            }
            result.Reverse();
            foreach (var item in result)
            {
                Console.Write(System.Convert.ToChar(System.Convert.ToUInt32(item, 16)));
            }
            Console.WriteLine();
        }
    }
}
