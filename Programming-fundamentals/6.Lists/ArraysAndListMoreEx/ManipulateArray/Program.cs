using System;
using System.Collections.Generic;
using System.Linq;

namespace ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = Console.ReadLine().Split(' ').ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                if (command[0]== "Reverse")
                {
                    arr.Reverse();
                    continue;
                }
                else if(command[0] == "Distinct")
                {
                    arr=arr.Distinct().ToList();
                    continue;
                }
                else if (command[0] == "Replace")
                {
                    int index = int.Parse(command[1]);
                    arr.Insert(index,command[2]);
                    arr.RemoveAt(index + 1);
                    continue;
                }
                else
                {
                    i--;
                    continue;
                }
                
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
