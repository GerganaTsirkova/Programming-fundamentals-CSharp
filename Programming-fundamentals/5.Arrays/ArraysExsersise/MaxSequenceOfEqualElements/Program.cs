using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int repeatedNumber = 0;
            int maxSeq = 1;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if(arr[i]==arr[i+1])
                {
                    counter++;
                    if (counter > maxSeq)
                    {
                        maxSeq = counter;
                        repeatedNumber = arr[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            if (maxSeq == 1)
            {
                repeatedNumber = arr[0];
            }
            for (int i = 0; i < maxSeq; i++)
            {
                Console.Write("{0} ",repeatedNumber);
            }
        }
    }
}
