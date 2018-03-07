using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int maxSeq = 0;
            int currSeq = 0;
            int counter = 0;
            int start = 0;
            for (int i = 0; i < num.Count - 1; i++)
            {
                if (num[i] == num[i + 1])
                {
                    currSeq++;
                    counter++;
                    if (currSeq > maxSeq)
                    {
                        maxSeq = currSeq;
                        if (counter >= 1)
                        {
                            start = num[i];
                        }
                    }
                }
                else
                {
                    counter = 0;
                    currSeq = 0;
                }

            }
            if (currSeq < 1)
            {
                Console.WriteLine(num[0]);
            }
            else
                for (int i = 0; i <= maxSeq; i++)
                {
                    Console.Write("{0} ", start);
                }

        }
    }
}

