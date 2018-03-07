using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideOfCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double result = 0;
            if (parameter == "face")
                result += FaceDiagonals(sideOfCube);
            if (parameter == "space")
                result += SpaceOfDiagonals(sideOfCube);
            if (parameter == "volume")
                result += VolumeOfCube(sideOfCube);
            if (parameter == "area")
                result += AreaOfCube(sideOfCube);
            Console.WriteLine("{0:f2}",result);
        }
        static double FaceDiagonals(double sideOfCube)
        {
            return Math.Sqrt(2*sideOfCube*sideOfCube);
        }
        static double SpaceOfDiagonals(double sideOfCube)
        {
            return Math.Sqrt(3 * sideOfCube * sideOfCube);
        }
        static double VolumeOfCube(double sideOfCube)
        {
            return sideOfCube * sideOfCube * sideOfCube;
        }
        static double AreaOfCube(double sideOfCube)
        {
            return 6 * sideOfCube * sideOfCube;
        }
    }
}
