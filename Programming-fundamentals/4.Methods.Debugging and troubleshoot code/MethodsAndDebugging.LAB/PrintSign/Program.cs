using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSign
{
    class Program
    {
        static void PrintSign(int n)
        {

            if (n < 0)
                Console.WriteLine($"The number {n} is negative.");
            else if (n > 0)
                Console.WriteLine($"The number {n} is positive.");
            else
                Console.WriteLine($"The number {n} is zero.");
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        
    }
}
