using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string dateStart = Console.ReadLine();
        DateTime startDate = Convert.ToDateTime(dateStart);
        string dateEnd = Console.ReadLine();
        DateTime endDate = Convert.ToDateTime(dateEnd);
        int holidaysCount = 0;
        for (DateTime date = startDate; date <= endDate; date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }
        }
        Console.WriteLine(holidaysCount);
    }
}