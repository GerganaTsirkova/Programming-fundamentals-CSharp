using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstLineX1 =  decimal.Parse(Console.ReadLine());
            decimal firstLineY1 =  decimal.Parse(Console.ReadLine());
            decimal firstLineX2 =  decimal.Parse(Console.ReadLine());
            decimal firstLineY2 =  decimal.Parse(Console.ReadLine());
            decimal secondLineX1 = decimal.Parse(Console.ReadLine());
            decimal secondLineY1 = decimal.Parse(Console.ReadLine());
            decimal secondLineX2 = decimal.Parse(Console.ReadLine());
            decimal secondLineY2 = decimal.Parse(Console.ReadLine());
            LongerLine(firstLineX1, firstLineX2, firstLineY1, firstLineY2, secondLineX1, secondLineX2, secondLineY1, secondLineY2);
        }
        static void LongerLine(decimal firstLineX1, decimal firstLineX2, decimal firstLineY1, decimal firstLineY2, decimal secondLineX1, decimal secondLineX2, decimal secondLineY1, decimal secondLineY2)
        {
            decimal firstLineLenght = Math.Abs(Math.Abs(firstLineX1 * firstLineY2) - Math.Abs(firstLineX2 * firstLineY1));
            decimal secondLineLenght = Math.Abs(Math.Abs(secondLineX1 * secondLineY2) - Math.Abs(secondLineX2 * secondLineY1));
            if (firstLineLenght >= secondLineLenght)
            {
                ClosestPoint(firstLineX1, firstLineX2, firstLineY1, firstLineY2);
            }
            else
            {
                ClosestPoint(secondLineX1, secondLineX2, secondLineY1, secondLineY2);
            }
        }
        static void ClosestPoint(decimal x1, decimal x2, decimal y1, decimal y2)
        {
            decimal distanceFirstPoint = (Math.Abs(x1 * x1) + Math.Abs(x2 * x2));
            decimal distanceSecondPoint = (Math.Abs(y1 * y1) + Math.Abs(y2 * y2));

            if (distanceFirstPoint <= distanceSecondPoint)
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            else
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);

        }
    }
}
