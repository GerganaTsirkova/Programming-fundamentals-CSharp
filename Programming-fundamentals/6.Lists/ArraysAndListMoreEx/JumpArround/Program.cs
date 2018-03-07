using System;
using System.Collections.Generic;
using System.Linq;

namespace JumpArround
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            long sum = num[0];
            int index = 0;
            while((index>=0)&&(index<=num.Count-1))
            {
                if(index + num[index]<=num.Count-1)
                {
                    index += num[index];
                    sum += num[index];
                }
                else
                {
                    if(index - num[index] >= 0)
                    {
                        index -= num[index];
                        sum += num[index];
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
