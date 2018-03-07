using System;

namespace Greets
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var rectangleArea = width * height;

            Console.WriteLine($"{rectangleArea:F2}");
        }
    }
}