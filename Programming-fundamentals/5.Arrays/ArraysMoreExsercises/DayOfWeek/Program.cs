using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] day = new string[7] { "Monday", "Tuesday", "Wednsday", "Thursday", "Friday", "Saturday", "Sunday" };
            int num = int.Parse(Console.ReadLine());
            switch(num)
            {
                case 1: Console.WriteLine(day[0]); break;
                case 2: Console.WriteLine(day[1]); break;
                case 3: Console.WriteLine(day[2]); break;
                case 4: Console.WriteLine(day[3]); break;
                case 5: Console.WriteLine(day[4]); break;
                case 6: Console.WriteLine(day[5]); break;
                case 7: Console.WriteLine(day[6]); break;
            }
            if((num<1)||(num>7))
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
