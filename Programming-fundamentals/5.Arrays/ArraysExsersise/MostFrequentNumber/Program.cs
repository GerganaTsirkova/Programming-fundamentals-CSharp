using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int max = 1;
            int leftNumber = 0;
            int frequentNumber = 0;
            for (int i = 0; i < arrInput.Length; i++)
            {
                counter = 1;
                for (int j = i + 1; j < arrInput.Length; j++)
                {
                    if (arrInput[i] == arrInput[j])
                    {
                        counter++;
                    }
                }
                if (counter > max)
                {
                    max = counter;
                    frequentNumber = arrInput[i];
                    if (leftNumber == 0)
                    {
                        leftNumber = frequentNumber;
                    }
                }
                else if ((counter == max)&&(max>1))
                {
                    frequentNumber = leftNumber;
                }
                else if ((counter == max) && (max == 1))
                {
                    frequentNumber = arrInput[0];
                }

            }
            
            Console.WriteLine(frequentNumber);
        }
    }
}
