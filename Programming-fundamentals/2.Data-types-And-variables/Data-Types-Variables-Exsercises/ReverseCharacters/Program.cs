using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = Convert.ToChar(Console.ReadLine());
            char secondLetter = Convert.ToChar(Console.ReadLine());
            char thirdLetter = Convert.ToChar(Console.ReadLine());
            string result = $"{thirdLetter}{secondLetter}{firstLetter}";
            Console.WriteLine(result);
        }
    }
}
