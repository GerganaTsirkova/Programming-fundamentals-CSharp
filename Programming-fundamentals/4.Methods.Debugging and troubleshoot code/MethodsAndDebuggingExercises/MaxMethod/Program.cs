using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int maxNumber= GetMax(firstNumber, secondNumber,thirdNumber);
            Console.WriteLine(maxNumber);
        }

        static int GetMax(int firstNumber, int secondNumber, int thirdNumber)
        {
            int maxBetweenFirstTwo = Math.Max(firstNumber, secondNumber);
            return Math.Max(maxBetweenFirstTwo, thirdNumber);
        }
        
    }
}
