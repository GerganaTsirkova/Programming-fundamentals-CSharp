using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            if ((n == 0)||(n==1))
                Console.WriteLine("False");
            else
            {
                bool isPrimeCheck = CheckMethod(n);
                if (isPrimeCheck)
                {
                    Console.WriteLine("True");
                }
                else
                    Console.WriteLine("False");
            }
            
        }

        static bool CheckMethod (long n)
        {
            bool isPrime=true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
                else
                {
                    isPrime = true;
                }
                
            }
            return isPrime;

        }
    }
}
