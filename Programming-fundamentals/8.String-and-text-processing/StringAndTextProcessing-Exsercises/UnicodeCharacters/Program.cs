using System;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\\u" + ((int)arr[i]).ToString("x").PadLeft(4, '0'));
            }
            Console.WriteLine();
        }
    }
}
