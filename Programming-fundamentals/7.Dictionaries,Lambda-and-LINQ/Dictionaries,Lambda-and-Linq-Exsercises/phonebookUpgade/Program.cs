using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            var phonebook = new SortedDictionary<string, string>();
            while (true)
            {

                if (input[0] == "A")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        phonebook[input[1]] = input[2];
                    }
                    else
                    {
                        phonebook.Add(input[1], input[2]);
                    }
                }
                else if (input[0] == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine("{0} -> {1}", input[1], phonebook[input[1]]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }

                }
                else if (input[0] == "END")
                {
                    break;
                }
                else if(input[0]== "ListAll")
                {
                    foreach (var contact in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", contact.Key, contact.Value);
                    }
                }
                input = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
