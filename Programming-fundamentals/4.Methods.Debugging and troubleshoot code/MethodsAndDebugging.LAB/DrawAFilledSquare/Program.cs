using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class Program
    {
        static void MiddlePart(int b)
        {
            for (int i = 0; i < b - 2; i++)
            {
                Console.Write("-");
                for (int j = 0; j < b - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }

        static void FirstEndLine(int a)
        {
            Console.WriteLine(new string('-', 2 * a));
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FirstEndLine(n);
            MiddlePart(n);
            FirstEndLine(n);
        }

        
    }
}
