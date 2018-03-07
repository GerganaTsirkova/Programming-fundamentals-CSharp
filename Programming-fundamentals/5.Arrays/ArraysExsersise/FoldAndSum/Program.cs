using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = inputArr.Length / 2;
            int[] firstRow = new int[k];
            int[] secondRow = new int[k];
            for (int i = 0; i < k/2 ; i++)
            {
                firstRow[i] = inputArr[k/2-i-1];
            }
            for (int i = 0; i < k ; i++)
            {
                secondRow[i] = inputArr[k/2+i];
            }
            for (int i = 0; i < k/2 ; i++)
            {
                firstRow[i + k/2]=inputArr[inputArr.Length-1 -i];
            }
            
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ",firstRow[i]+secondRow[i]);
            }
            Console.WriteLine();
        }
    }
}
