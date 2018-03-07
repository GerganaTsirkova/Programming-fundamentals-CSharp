using System;

namespace Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double hours = double.Parse(Console.ReadLine());
            double minets = double.Parse(Console.ReadLine());
            minets += 30;
            if(minets>=60)
            {
                if(hours<=22)
                {
                    hours++;
                    minets -= 60;
                }
                else
                {
                    hours = 0;
                    minets -= 60;
                }
            }
            
            Console.WriteLine($"{hours}:{minets:00}");
            



        }
    }
}
