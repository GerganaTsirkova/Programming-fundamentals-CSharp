using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativeAndRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> positiveNumbers = new List<int>();
            foreach(int item in numbers)
            {
                if(item >= 0)
                {
                    positiveNumbers.Add(item);
                }
            }
            if (positiveNumbers.Capacity == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                positiveNumbers.Reverse();
                Console.WriteLine(string.Join(" ", positiveNumbers));
            }
        }
    }
}
