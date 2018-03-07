using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpliByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
            .Split(new char[] { ',', ';', ' ', '.', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' },StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();
            foreach(string w in words)
            {
                var typeWord = GetWordType (w);
                if(typeWord==WordType.UpperCase)
                {
                    upperCase.Add(w);
                }
                else if (typeWord == WordType.LowerCase)
                {
                    lowerCase.Add(w);
                }
                else
                {
                    mixedCase.Add(w);
                }
                
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
        }
        enum WordType { UpperCase, Mixedcase, LowerCase }
        static WordType GetWordType(string words)
        {
            int lowerLetters = 0;
            int upperLetters = 0;
            foreach(var l in words)
            {
                if(char.IsUpper(l))
                {
                    upperLetters++;
                }
                else if (char.IsLower(l))
                {
                    lowerLetters++;
                }
            }
            if(upperLetters==words.Length)
            {
                return WordType.UpperCase;
            }
            else if (lowerLetters==words.Length)
            {
                return WordType.LowerCase;
            }
            else
            {
                return WordType.Mixedcase;
            }
        }
    }
}
