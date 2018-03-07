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
            int counter = 0;
            int startNumber = 0;
            int curentSeq = 0;
            int maxSeq = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] - arr[i-1]>=1)
                {
                    counter++;
                    curentSeq = i - counter;
                    if (counter > maxSeq)
                    {
                        maxSeq = counter;
                        startNumber = curentSeq;
                    }
                    
                }
                else
                {

                    counter = 0;
                }
            }

            for (int i = startNumber; i <= maxSeq+startNumber; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}

