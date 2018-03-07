using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substringbroken
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 112)
                {
                    hasMatch = true;

                    int endIndex = jump;

                    if (endIndex > text.Length)
                    {
                        endIndex = text.Length;
                    }
                    string matchedString = text.Length - i <= jump ? text.Substring(i) : text.Substring(i, jump + 1);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (hasMatch == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
