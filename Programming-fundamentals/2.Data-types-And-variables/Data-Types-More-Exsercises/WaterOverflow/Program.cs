using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());
            int littresTotal = 0;
            for (int i = 0; i < numberLines; i++)
            {
                int littres = int.Parse(Console.ReadLine());
                if(littres+littresTotal>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    littresTotal += littres;
                }
            }
            Console.WriteLine(littresTotal);

        }
    }
}
