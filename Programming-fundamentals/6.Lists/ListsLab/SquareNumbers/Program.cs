using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> squareNums = new List<double>();
            foreach(var num in input)
            {
                if(Math.Sqrt(num)==(int)Math.Sqrt(num))
                {
                    squareNums.Add(num);
                }
            }
            squareNums.Sort();
            squareNums.Reverse();
            Console.WriteLine(string.Join(" ",squareNums));
        }
    }
}
