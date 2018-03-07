using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                bool isPalindrome = IsPalindrome(i);
                bool sumDivisible7 = SumDivisibleBy7(i);
                bool oneEvenDigit = OneEvenDigit(i);
                if ((isPalindrome == true) && (sumDivisible7 == true) && (oneEvenDigit == true))
                    Console.WriteLine(i);
            }

        }

        static bool OneEvenDigit(int number)
        {
            string value = number.ToString();
            int counter = 0;
            for (int i = 0; i < value.Length; i++)
            {
                int num = number % 10;
                if (num % 2 == 0)
                    counter++;
                number /= 10;
            }

            if (counter != 0)
                return true;
            else
                return false;
        }

        static bool SumDivisibleBy7(int valueOfNumber)
        {
            string value = valueOfNumber.ToString();
            int sum = 0;
            for (int i = 0; i < value.Length; i++)
            {
                int num = valueOfNumber % 10;
                sum += num;
                valueOfNumber /= 10;
            }
            if ((sum % 7 == 0))
                return true;
            else
                return false;

        }

        static bool IsPalindrome(int valueOfNumber)
        {
            string value = valueOfNumber.ToString();
            for (int i = 0; i < value.Length; i++)
                if (value[i] != value[value.Length - 1 - i]) return false;
            return true;
        }





    }
}
