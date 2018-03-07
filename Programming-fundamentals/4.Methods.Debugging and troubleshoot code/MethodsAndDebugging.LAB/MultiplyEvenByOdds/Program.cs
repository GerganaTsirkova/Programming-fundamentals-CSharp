using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvenByOdds
{
    class Program
    {
        static int MultiplyEvenByOdds(int number)
        {
            int sumEvens = EvenSum(number);
            int sumOdds = OddSum(number);
            return sumEvens * sumOdds;
        }

        static int OddSum(int num)
        {
            int sumOdds = 0;
            num = Math.Abs(num);
            int singleNum = num % 10;

            while (singleNum > 0)
            {

                if (singleNum % 2 != 0)
                {
                    sumOdds += singleNum;
                }
                num = num / 10;
                singleNum = num % 10;
            }
            return sumOdds;
        }

        static int EvenSum(int num)
        {
            int sumEvens = 0;
            num = Math.Abs(num);
            int singleNum = num % 10;
            while (singleNum > 0)
            {

                if (singleNum % 2 == 0)
                {
                    sumEvens += singleNum;
                }
                num = num / 10;
                singleNum = num % 10;

            }
            return sumEvens;
        }

        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            if (n == 0)
            {
                Console.WriteLine(n);
            }
            else
            {
                int result = MultiplyEvenByOdds(n);
                Console.WriteLine(result);
            }
        }


    }
}

