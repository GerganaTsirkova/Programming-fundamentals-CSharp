using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float speedMeterPerSecond = distance / (3600 * hours + 60 * minutes + seconds);
            Console.WriteLine(speedMeterPerSecond);
            float timeInHours = hours + minutes / 60 + seconds / 3600;
            float speedKilometersPerHour = (distance / 1000) / timeInHours;
            Console.WriteLine(speedKilometersPerHour);
            float milePerHours = (distance / 1609) / timeInHours;
            Console.WriteLine(milePerHours);
        }
    }
}
