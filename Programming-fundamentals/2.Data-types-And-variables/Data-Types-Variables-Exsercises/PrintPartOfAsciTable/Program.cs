using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPartOfAsciTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int final = int.Parse(Console.ReadLine());

            for (int i = start; i <=final; i++)
            {
                char characters = (char)i;
                Console.Write(characters+" ");
            }
        }
    }
}
