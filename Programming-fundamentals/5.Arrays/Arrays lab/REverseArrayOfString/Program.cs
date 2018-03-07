using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REverseArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            string[] reversed = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversed[i] = arr[arr.Length-1-i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ",reversed[i]);
            }
            Console.WriteLine();

        }
    }
}
