using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbersAwawayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> Numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            for (int i = 0; i < Numbers.Count; i++)
            {
                Console.Write("{0} => ",Numbers[i]);
                Numbers[i] = Math.Round(Numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine("{0}",Numbers[i]);
            }
        }
    }
}
