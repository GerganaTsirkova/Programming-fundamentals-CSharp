using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|').ToList();
            numbers.Reverse();
            List<string> result = new List<string>();
            foreach (var item in numbers)
            {
                numbers = item.Split(' ').ToList();
                result.Add(item);
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
