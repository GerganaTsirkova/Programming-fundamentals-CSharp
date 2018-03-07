using System;

namespace TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperial = Console.ReadLine();
            decimal value = decimal.Parse(Console.ReadLine());
            decimal result = 0m;
            string metric = "";
            if(imperial=="miles")
            {
                result += value * 1.6m;
                metric = "kilometers";
            }
            else if (imperial=="inches")
            {
                result += value * 2.54m;
                metric = "centimeters";
            }
            else if (imperial == "feet")
            {
                result += value * 30m;
                metric = "centimeters";
            }
            else if (imperial == "yards")
            {
                result += value * 0.91m;
                metric = "meters";
            }
            else if (imperial == "gallons")
            {
                result += value * 3.8m;
                metric = "liters";
            }
            Console.WriteLine($"{value} {imperial} = {result:f2} {metric}");
        }
    }
}
