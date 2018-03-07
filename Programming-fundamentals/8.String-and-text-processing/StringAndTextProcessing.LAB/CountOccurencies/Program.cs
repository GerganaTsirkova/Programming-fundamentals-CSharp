using System;

namespace _2.CountOccurencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string strToSearchFor = Console.ReadLine();
            int index = input.IndexOf(strToSearchFor);
            int count = 0;
            while(index != -1)
            {
                count++;
                index = input.IndexOf(strToSearchFor,index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
