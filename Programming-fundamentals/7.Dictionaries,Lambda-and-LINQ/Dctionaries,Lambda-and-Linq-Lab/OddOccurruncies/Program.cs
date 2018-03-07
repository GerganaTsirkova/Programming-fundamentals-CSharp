using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurruncies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(' ');
            var oddNames = new Dictionary<string, int>();
            List<string> result = new List<string>();
            foreach (var name in words)
            {
                if (oddNames.ContainsKey(name))
                {
                    oddNames[name]++;
                }
                else
                {
                    oddNames.Add(name,1);
                }

            }
            foreach (var item in oddNames)
            {
                if(item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
