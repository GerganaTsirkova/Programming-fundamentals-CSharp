using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger result=CalculatingFactoriel(number);
            Console.WriteLine(result);
        }
         static BigInteger CalculatingFactoriel(int number)
        {
            BigInteger result = 1;
            for (int i = 1; i <=number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
