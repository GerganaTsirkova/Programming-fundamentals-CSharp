using System;
using System.Collections.Generic;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resourse = new Dictionary<string, string>();
            string comand = Console.ReadLine();
            int count = 0;
            string oldComand = "";
            while (true)
            {
                if(comand=="stop")
                {
                    break;
                }
                else
                {
                    
                    count++;
                    if (count % 2 == 0)
                    {
                        resourse[oldComand] = comand;
                    }
                    else if (!(resourse.ContainsKey(comand)))
                    {
                        resourse.Add(comand, null);
                        oldComand = comand;
                    }
                }
                comand = Console.ReadLine();
            }
            foreach (var name in resourse)
            {
                Console.WriteLine("{0} -> {1}",name.Key,name.Value);
            }
            
        }
    }
}
