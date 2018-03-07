using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            var count = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if(count.ContainsKey(num)==false)
                {
                    count.Add(num, 0);

                }
                count[num]++;
            }
            foreach (var item in count)
            {
                Console.WriteLine("{0} -> {1}",item.Key,item.Value);
            }
        }
    }
}
