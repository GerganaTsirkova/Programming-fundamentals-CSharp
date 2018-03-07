using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    class Program
    {
        static double Conversion(double farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            Conversion(n);
            double resultInCelsius = Conversion(n);
            Console.WriteLine("{0:f2}",resultInCelsius);
        }
        
    }
}
