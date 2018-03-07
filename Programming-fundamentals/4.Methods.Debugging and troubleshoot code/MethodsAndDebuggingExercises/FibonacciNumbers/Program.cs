using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long fibNumber=TheNFibonacciNumber(number);
            if (number == 0)
                fibNumber = 1;
            if (number == 1)
                fibNumber = 1;
            if (number == 2)
                fibNumber = 2;
            Console.WriteLine(fibNumber);
        }
        static long TheNFibonacciNumber(long number)
        {
            int a = 1;
            int b = 1;
            int helpedPrimitive = 0;
            for (int i = 2; i <=number; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
                if (i == number)
                    helpedPrimitive += temp;
            }
            
            return helpedPrimitive;
           
        }
    }
}
