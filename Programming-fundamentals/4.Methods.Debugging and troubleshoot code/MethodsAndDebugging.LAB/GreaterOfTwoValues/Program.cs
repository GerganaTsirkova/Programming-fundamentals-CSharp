using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class Program
    {
        static int IntResult(int first, int second)
        {
            return Math.Max(first, second);
        }
        static char CharResult(char first, char second)
        {
            if (first > second)
                return first;
            else
                return second;
        }
        static string StringResult(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
                return first;
            else
                return second;

        }
        static void Main(string[] args)
        {
            string typeOfData = Console.ReadLine();

            if (typeOfData == "int")
            {
                int fir = int.Parse(Console.ReadLine());
                int sec = int.Parse(Console.ReadLine());
                int max = IntResult(fir, sec);
                Console.WriteLine(max);
            }
            else if (typeOfData=="char")
            {
                char fir = char.Parse(Console.ReadLine());
                char sec = char.Parse(Console.ReadLine());
                char max = CharResult((char)fir,sec);
                Console.WriteLine(max);
            }
            else if (typeOfData == "string")
            {
                string fir = Console.ReadLine();
                string sec = Console.ReadLine();
                string max = StringResult(fir, sec);
                Console.WriteLine(max);
            }

        }
    }
}
