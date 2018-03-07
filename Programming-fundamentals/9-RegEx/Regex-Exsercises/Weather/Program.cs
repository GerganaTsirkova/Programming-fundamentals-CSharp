using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, SortedDictionary<double, string>> weatherData = new SortedDictionary<string, SortedDictionary<double, string>>();

            while(input != "end")
            {
                string pattern = @"(?<city>[A-Z]{1}[A-Z]{1})(?<temp>[0-9]+\.([0-9]+))(?<weather>[A-Za-z]+)\|";
                var matches = Regex.Match(input, pattern);
                if(matches.Success==true)
                {
                    var city = matches.Groups["city"].Value;
                    var temperature = double.Parse(matches.Groups["temp"].Value);
                    var weather = matches.Groups["weather"].Value;
                    weather = weather.TrimEnd('|');
                    var insideDict = new SortedDictionary<double, string>();
                    insideDict.Add(temperature, weather);
                    if(!weatherData.ContainsKey(city))
                    {
                        weatherData.Add(city, insideDict);
                    }
                    else
                    {
                        weatherData[city].Clear();
                        weatherData[city].Add(temperature,weather);
                    }
                    
                }
                input = Console.ReadLine();
            }
            foreach (var data in weatherData.OrderBy(x => x.Value.Average(y => y.Key)))
            {
                Console.Write($"{data.Key}");
                foreach (var city in data.Value)
                {
                    Console.WriteLine(" => {0:f2} => {1}",city.Key,city.Value);
                }
            }

        }
    }
}
