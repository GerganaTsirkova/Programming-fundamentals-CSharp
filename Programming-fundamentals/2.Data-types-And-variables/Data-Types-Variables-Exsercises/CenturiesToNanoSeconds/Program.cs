using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToNanoSeconds
{
    class Program
    {
        static void Main(string[] args)
        {

            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.242);
            int hours = days * 24;
            decimal minutes = (decimal)hours * 60;
            decimal seconds = minutes * 60;
            decimal miliseconds = seconds * 1000;
            decimal microseconds = miliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
