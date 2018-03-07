using System;
using System.Linq;

namespace CondenseAttayToNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int number = 0;
            int len = num.Length;
            while(true)
            {
                if(num.Length==1)
                {
                    number += num[0];
                    break;
                }
                int[] condenseArr = new int[len - 1];
                for (int i = 0; i < len-1; i++)
                {
                    condenseArr[i] = num[i] + num[i + 1];
                    num[i] = condenseArr[i];
                }
                if(condenseArr.Length == 1)
                {
                    number += condenseArr[0];
                    break;
                }
                len--;
            }
            Console.WriteLine(number);
        }
    }
}
