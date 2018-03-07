﻿using System;

namespace CharSTar
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: {0}{1}{2}{0}", new string('|', 1), new string('|', currentHealth), new string('.', maximumHealth - currentHealth));
            Console.WriteLine("Energy: {0}{1}{2}{0}", new string('|', 1), new string('|', currentEnergy), new string('.', maximumEnergy - currentEnergy));
        }
    }
}
