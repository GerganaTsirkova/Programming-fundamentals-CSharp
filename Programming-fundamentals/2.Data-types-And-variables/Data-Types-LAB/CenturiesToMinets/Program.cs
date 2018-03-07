using System;

namespace _1.CenturiesToMinets
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            long days = (long)(years * 365.2422);
            long hours = days * 24;
            long minets = hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minets} minutes");
        }
    }
}
