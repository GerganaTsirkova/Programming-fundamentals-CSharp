using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.SupermarketDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            var supermarketDatabase = new Dictionary<string, Dictionary<double, double>>();
            double tptalPrice = 0.00;
            var oldquantity = new Dictionary<string, double>();
            while (input[0] != "stocked")
            {
                string name = input[0];
                double price = double.Parse(input[1]);
                double quantity = double.Parse(input[2]);
                if(!supermarketDatabase.ContainsKey(name))
                {
                    var priceAndQuantity = new Dictionary<double, double>();
                    priceAndQuantity.Add(double.Parse(input[1]), double.Parse(input[2]));
                    supermarketDatabase.Add(name,priceAndQuantity);
                    oldquantity.Add(name, quantity);
                }
                else
                {
                    supermarketDatabase.Remove(name);
                    var priceAndQuantity = new Dictionary<double, double>();
                    priceAndQuantity.Add(double.Parse(input[1]), double.Parse(input[2])+oldquantity[name]);
                    supermarketDatabase.Add(name, priceAndQuantity);
                    oldquantity.Remove(name);
                    oldquantity.Add(name, priceAndQuantity[price]);
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }
            foreach (var item in supermarketDatabase)
            {
                foreach (var i in item.Value)
                {
                    tptalPrice += i.Key * i.Value;
                }
            }
            foreach (var item in supermarketDatabase)
            {
                foreach (var i in item.Value)
                {
                    Console.WriteLine("{0}: ${1:f2} * {2} = ${3:0.00}",item.Key,i.Key,i.Value,i.Key*i.Value);
                }
            }
            Console.WriteLine(new string('-',30));
            Console.WriteLine("Grand Total: ${0:0.00}",tptalPrice);
        }
    }
}
