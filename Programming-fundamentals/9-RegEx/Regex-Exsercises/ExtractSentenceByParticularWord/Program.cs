using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractSentenceByParticularWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            List<string> text = Console.ReadLine()
                .Split(new char[] { '!', '.', '?' })
                .ToList();
            
            for (int i = 0; i < text.Count; i++)
            {
                string sentence = text[i].ToString();
                string wordPattern = $@"\b{word}\b";
                var matches = Regex.Matches(sentence, wordPattern);
                if(matches.Count>0)
                {
                    string result = text[i].Trim().ToString();
                    Console.WriteLine(result);
                }
                
            }
        }
    }
}
