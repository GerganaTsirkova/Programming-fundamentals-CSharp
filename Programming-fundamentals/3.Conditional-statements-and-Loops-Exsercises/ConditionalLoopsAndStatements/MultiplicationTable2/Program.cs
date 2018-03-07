using System;

namespace MultiplicationTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multiplayer = int.Parse(Console.ReadLine());
            if (multiplayer <= 10)
            {
                for (int i = multiplayer; i <= 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", num, i, num * i);
                }
            }
            else
            {
                Console.WriteLine("{0} X {1} = {2}", num, multiplayer, num * multiplayer);
            }
        }
    }
}
