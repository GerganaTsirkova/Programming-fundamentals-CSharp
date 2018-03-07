using System;
using System.Collections.Generic;
using System.Linq;

namespace Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            decimal priceOfJewels = price[0];
            decimal countJewels = 0;
            decimal priceOfGold = price[1];
            decimal countGold = 0;
            decimal totalStolenMoney = 0;
            decimal totalExpences = 0;
            string[] input = Console.ReadLine().Split(' ').ToArray();
            while ((input[0] != "Jail")&&(input[1] != "Time"))
            {
                string loot = input[0];
                decimal expences = decimal.Parse(input[1]);
                char[] c = loot.ToCharArray();
                foreach (var ch in c)
                {
                    if(ch=='%')
                    {
                        countJewels++;
                    }
                    else if(ch=='$')
                    {
                        countGold++;
                    }
                }
                totalStolenMoney += countJewels * priceOfJewels + countGold * priceOfGold;
                totalExpences += expences;
                countGold = 0;
                countJewels = 0;
                input = Console.ReadLine().Split(' ').ToArray();
            }
            if(totalStolenMoney>=totalExpences)
            {
                Console.WriteLine("Heists will continue. Total earnings: {0}.", totalStolenMoney - totalExpences);
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpences-totalStolenMoney}.");
            }
        }
    }
}
