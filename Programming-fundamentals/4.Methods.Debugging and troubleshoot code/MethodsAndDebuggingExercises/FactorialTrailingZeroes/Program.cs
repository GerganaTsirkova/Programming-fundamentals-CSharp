using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger result = CalculatingFactoriel(number);
            BigInteger numberOfZeroes = CountingZeroes(result);
            Console.WriteLine(numberOfZeroes);
        }

        static BigInteger CountingZeroes(BigInteger result)
        {
            int counter = 0;

            do
            {
                BigInteger num = result % 10;

                if (num == 0) counter++;
                else break;

                result /= 10;
            }
            while (true);

            return counter;
        }

        static BigInteger CalculatingFactoriel(BigInteger number)
        {
            BigInteger result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
