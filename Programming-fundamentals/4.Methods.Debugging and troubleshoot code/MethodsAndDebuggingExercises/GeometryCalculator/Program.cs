using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double result = 0;
            if (input=="triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                result +=Triangle(side, height);
            }
            else if (input=="square")
            {
                double side = double.Parse(Console.ReadLine());
                result += Square(side);
            }
            else if (input == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double lenght = double.Parse(Console.ReadLine());
                result += Rectangle(width, lenght);
            }
            else if (input == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                result += Circle(radius);
            }
            Console.WriteLine("{0:f2}",result);
        }

        static double Triangle(double side, double height)
        {
            return side*height/2;
        }
        static double Square(double side)
        {
            return side * side;
        }
        static double Rectangle(double side, double height)
        {
            return side * height ;
        }
        static double Circle(double radius)
        {
            return Math.PI*radius*radius;
        }
    }
}
