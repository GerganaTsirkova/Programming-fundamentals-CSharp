﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrDayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int days = int.Parse(Console.ReadLine());
            if (days >=1 && days<=7)
                Console.WriteLine(arrDayOfWeek[days-1]);
            else
                Console.WriteLine("Invalid day!");
        }
    }
}
