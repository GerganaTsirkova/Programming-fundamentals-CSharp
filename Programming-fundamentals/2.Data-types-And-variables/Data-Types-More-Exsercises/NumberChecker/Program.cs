using System;
using System.Numerics;

namespace NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            bool isFloatNum = double.TryParse(number, out double resultFloat);
            bool isInt = long.TryParse(number, out long resultLong);
            if (isInt==true)
            {
                Console.WriteLine("integer");
            }
            else if(isFloatNum==true)
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
