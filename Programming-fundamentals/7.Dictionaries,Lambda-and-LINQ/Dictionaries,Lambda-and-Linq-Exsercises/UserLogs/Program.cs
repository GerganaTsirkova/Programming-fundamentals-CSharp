using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> site = new Dictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine().Split('=').ToArray();
            string user;
            string ip;
            while (input[0] != "end")
            {
                string[] ipInput = input[1].Split(' ').ToArray();
                ip = ipInput[0];

                user = input[input.Length-1];

                if (!(site.ContainsKey(user)))
                {
                    Dictionary<string, int> current = new Dictionary<string, int>();
                    site.Add(user, current);
                }
                else
                {
                    if (!(site[user].ContainsKey(ip)))
                    {
                        site[user].Add(ip, 1);
                    }
                    else
                    {
                        site[user][ip]++;
                    }
                }
                input = Console.ReadLine().Split('=').ToArray();
            }
    
            foreach (var currentUser in site.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}: ", currentUser.Key);
                foreach (var ippair in currentUser.Value)
                {
                    Console.Write("{0} => {1}", ippair.Key, ippair.Value);
                }
            }
        }
    }
}
