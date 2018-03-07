using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrFirst = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arrSecond = Console.ReadLine().Split().Select(char.Parse).ToArray();
            bool isSecond = false;
            int minLenght = Math.Min(arrFirst.Length, arrSecond.Length);
            for (int i = 0; i < minLenght; i++)
            {
                int first = arrFirst[i];
                int second = arrSecond[i];
                if (first > second)
                {
                    isSecond = true;
                }
                else
                    break;
            }
            if (((arrSecond.Length == minLenght) && (arrFirst.Length>minLenght)) || isSecond == true)
            {
                Console.WriteLine(string.Join("", arrSecond));
                Console.WriteLine(string.Join("", arrFirst));
            }
            else
            {
                Console.WriteLine(string.Join("", arrFirst));
                Console.WriteLine(string.Join("", arrSecond));
            }
        }
    }
}
