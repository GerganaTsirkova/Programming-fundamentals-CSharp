using System;
using System.Collections.Generic;
using System.Linq;

namespace GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int occurNum = int.Parse(Console.ReadLine());
            long sum = 0;
            int index = 0;
            int counterOcur = 0;
            int counterSecond = 0;
            
            for (int i = 0; i < num.Count; i++)
            {
                if(num[i]==occurNum)
                {
                    counterOcur++;
                    for (int j = i+1; j < num.Count; j++)
                    {
                        if(num[j]==occurNum)
                        {
                            index = j;
                            counterSecond++;
                        }
                        
                    }
                    if(counterSecond==0)
                    {
                        index = i;
                    }
                    for (int j = 0; j < index ; j++)
                    {
                        sum += num[j];
                    }
                    break;
                }
            }
            if(counterOcur==0)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
