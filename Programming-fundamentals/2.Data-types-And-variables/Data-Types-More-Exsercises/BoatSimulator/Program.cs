using System;

namespace BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = Convert.ToChar(Console.ReadLine());
            char secondBoat = Convert.ToChar(Console.ReadLine());
            int firstBoatScore = 0;
            int seconBoatScore = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                if(command=="UPGRADE")
                {
                    firstBoat = (char)(firstBoat + 3);
                    secondBoat = (char)(secondBoat + 3);
                    continue;
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        seconBoatScore += command.Length;
                        if (seconBoatScore >= 50)
                        {
                            Console.WriteLine(seconBoatScore);
                            break;
                        }
                    }
                    else
                    {
                        firstBoatScore += command.Length;
                        if (firstBoatScore >= 50)
                        {
                            Console.WriteLine(firstBoat);
                            break;
                        }
                    }
                }
            }
            if((firstBoatScore<50)&&(seconBoatScore<50))
            {
                if(firstBoatScore>seconBoatScore)
                {
                    Console.WriteLine(firstBoat);
                }
                else
                {
                    Console.WriteLine(secondBoat);
                }
            }
        }
    }
}
