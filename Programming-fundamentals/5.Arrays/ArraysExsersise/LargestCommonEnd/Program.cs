using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string sFirst = Console.ReadLine();
            string[] wordsFirst = sFirst.Split(' ');
            string sSecond = Console.ReadLine();
            string[] wordsSecond = sSecond.Split(' ');
            int counter = 0;
            if (wordsFirst[0] == wordsSecond[0])
            {
                for (int i = 0; i < Math.Min(wordsFirst.Length, wordsSecond.Length); i++)
                {
                    if (wordsFirst[i] == wordsSecond[i])
                    {
                        counter++;
                    }
                }
            }
            else
            {
                Array.Reverse(wordsFirst);
                Array.Reverse(wordsSecond);
                for (int i = 0; i < Math.Min(wordsFirst.Length, wordsSecond.Length); i++)
                {
                    
                    if (wordsFirst[i] == wordsSecond[i])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
            
        }
    }
}
