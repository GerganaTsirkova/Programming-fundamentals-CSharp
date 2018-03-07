using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int l = numbers.Length;

        MaxIncSequence(numbers, l);
    }

    static void MaxIncSequence(int[] numbers, int l)
    {
        int counter = 0;
        int startCurrSeq = 0;
        int maxSeq = 0;
        int startNum = 0;

        for (int i = 1; i < l; i++)
        {
            if (numbers[i] - numbers[i - 1] >= 1)
            {
                counter++;
                startCurrSeq = i - counter;

                if (counter > maxSeq)
                {
                    maxSeq = counter;
                    startNum = startCurrSeq;
                }
            }
            else
            {
                counter = 0;
            }
        }
        for (int iWrite = startNum; iWrite <= (startNum + maxSeq); iWrite++)
        {
            Console.Write(numbers[iWrite] + " ");
        }
        Console.WriteLine();
    }
}