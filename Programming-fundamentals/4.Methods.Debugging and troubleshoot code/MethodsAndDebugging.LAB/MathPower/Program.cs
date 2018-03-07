using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static double MathPower(double first, double second)
        {
            return Math.Pow(first, second);
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            MathPower(a, b);
            double result = MathPower(a, b);
            Console.WriteLine(result);
        }

        
    }
}
