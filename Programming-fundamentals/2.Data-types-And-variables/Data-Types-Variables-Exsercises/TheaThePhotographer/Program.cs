using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double picNumbers = double.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine());
            double filterFactor = double.Parse(Console.ReadLine());
            double uploadTime = double.Parse(Console.ReadLine());
            double goodPictures = Math.Ceiling(picNumbers * filterFactor / 100);
            double totalTime = picNumbers * filterTime + goodPictures * uploadTime;
            TimeSpan t = TimeSpan.FromSeconds(totalTime);
            string answer = string.Format("{0}:{1:00}:{2:00}:{3:00}",t.Days,t.Hours,t.Minutes,t.Seconds);
            Console.WriteLine(answer);


        }
    }
}
