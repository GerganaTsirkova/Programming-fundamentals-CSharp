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
            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "END")
            {
                if (command[0] == "Reverse")
                {
                    arr.Reverse();
                }
                else if (command[0] == "Distinct")
                {
                    arr = arr.Distinct().ToList();
                }
                else if (command[0] == "Replace")
                {
                    int index = int.Parse(command[1]);
                    if((index>arr.Count-1)||(index<0))
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        arr.Insert(index, command[2]);
                        arr.RemoveAt(index + 1);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine().Split(' ');
            }
            Console.WriteLine(string.Join(", ", arr));
            
        }
    }
}
