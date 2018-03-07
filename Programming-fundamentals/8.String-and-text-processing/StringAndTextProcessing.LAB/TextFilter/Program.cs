using System;
using System.Linq;

namespace _3.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine()
                                .Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries)
                                .ToArray(); // TODO: add separators
            string text = Console.ReadLine();
            foreach (var banWord in banWords)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord,new string('*', banWord.Length));
                }
            }
            Console.WriteLine(text);

        }
    }
}
