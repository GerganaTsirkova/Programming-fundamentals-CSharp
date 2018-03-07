using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
            {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = arr.Length;
            int result = 0;
            if (arr.Length==1)
            {
                Console.WriteLine(arr[0]);
            }
            else
            {
                while (count > 1)
                {
                    int[] condenseArr = new int [count - 1];
                    for (int i = 0; i < condenseArr.Length; i++)
                    {
                        condenseArr[i] = arr[i] + arr[i + 1];
                        arr[i]= condenseArr[i];
                    }
                    
                    count--;
                    if (count == 1)
                        result += condenseArr[0];
                }
                Console.WriteLine(result);
            }
        }
    }
}
