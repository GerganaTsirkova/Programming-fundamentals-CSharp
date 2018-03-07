using System;

namespace Greets
{
    class Program
    {
        static void Main(string[] args)
        {
            var mile = double.Parse(Console.ReadLine());
            var kilometers = 1.60934;
            var convertMileToKilometers = mile * kilometers;

            Console.WriteLine($"{convertMileToKilometers:F2}");
        }
    }
}