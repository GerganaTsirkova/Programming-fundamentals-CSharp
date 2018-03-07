using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculetaTriangleArea
{
    class Program
    {
        static double triangleArea(double basee, double height)
        {
            return (basee * height) / 2;
        }
        static void Main(string[] args)
        {
            double triangleBase = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            triangleArea(triangleBase,triangleHeight);
            double area = triangleArea(triangleBase, triangleHeight);
            Console.WriteLine(area);
        }

        
    }
}
