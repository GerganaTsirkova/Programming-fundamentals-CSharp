using System;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter = 0;
            while (true)
            {
                num = int.Parse(Console.ReadLine());
                num = Math.Abs(num);
                if (num % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                    counter++;
                    if (counter>=10)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("The number is: {0}",num);
                    break;
                }
            }
        }
    }
}
