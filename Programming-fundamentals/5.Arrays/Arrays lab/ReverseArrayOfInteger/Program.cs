using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayInputInt = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayInputInt[i] = int.Parse(Console.ReadLine());
            }
            for (int i = n-1; i >=0 ; i--)
            {
                Console.WriteLine(arrayInputInt[i]);
            }
        }
    }
}
