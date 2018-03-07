using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reversed=ReverseSymbolsString(input);
            Console.WriteLine(reversed);
        }

        static string ReverseSymbolsString(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
