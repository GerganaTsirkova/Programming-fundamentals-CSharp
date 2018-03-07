using System;
using System.Collections.Generic;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resourse = new Dictionary<string, int>();
            int counter = 1;
            string comand = Console.ReadLine();
            string commandbefore = "";
            
            while(comand != "stop")
            {
                if (counter % 2 != 0)
                {
                    if (!(resourse.ContainsKey(comand)))
                    {
                        resourse.Add(comand, 0);
                    }
                    commandbefore = comand;
                }
                else
                {
                    int value = int.Parse(comand);
                    resourse[commandbefore] += value ;
                }
                comand = Console.ReadLine();
                counter++;
            }
            foreach (var item in resourse)
            {
                Console.WriteLine("{0} -> {1}",item.Key, item.Value);
            }
        }
    }
}
