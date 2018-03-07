using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForANumber
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] arrOfThree = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            List<int> secondList = new List<int>();
            List<int> finalList = new List<int>();

            for (int i = 0; i < arrOfThree[0]; i++)
            {
                secondList.Add(input[i]);
                
            }
            for (int i = arrOfThree[1]; i <secondList.Count; i++)
            {
                finalList.Add(secondList[i]);
            }

            for (int i = 0; i < finalList.Count; i++)
            {
                if(arrOfThree[2]==finalList[i])
                {
                    counter++;
                }
            }
            
            if (counter>0)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
            
        }
    }
}
