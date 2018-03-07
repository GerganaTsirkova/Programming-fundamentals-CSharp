using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = 0;
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sumLeft = 0;
                sumRight = 0;
                if (i == 0)
                {
                    sumLeft = 0;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        sumLeft += array[j];
                    }
                }
                if (i == array.Length - 1)
                {
                    sumRight = 0;
                }
                else
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        sumRight += array[j];
                    }
                }
                if (sumLeft == sumRight)
                {
                    index = i;
                }
            }
            if ((index == 0) || (array.Length == 1))
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
