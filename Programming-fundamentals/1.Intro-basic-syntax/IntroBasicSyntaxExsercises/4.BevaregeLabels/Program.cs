using System;

namespace Greets
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameOfProduct = Console.ReadLine();
            var volumeOfProduct = int.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());

            Console.WriteLine($"{volumeOfProduct}ml {nameOfProduct}:");
            Console.WriteLine($"{(volumeOfProduct * energyContent) / 100.0}kcal, {(volumeOfProduct * sugarContent) / 100.0}g sugars");
        }
    }
}