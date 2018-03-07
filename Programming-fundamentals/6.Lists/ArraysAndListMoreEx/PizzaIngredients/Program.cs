using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ingredients = Console.ReadLine()
                .Split(' ')
                .ToList();
            int maxLen = int.Parse(Console.ReadLine());
            int counterIngredients = 0;
            List<string> listPropperIng = new List<string>();

            for (int i = 0; i < ingredients.Count; i++)
            {
                string ing = ingredients[i];
                if(ing.Length==maxLen)
                {
                    Console.WriteLine($"Adding {ing}.");
                    counterIngredients++;
                    listPropperIng.Add(ing);
                }
                if(counterIngredients==10)
                {
                    break;
                }
            }
            Console.WriteLine($"Made pizza with total of {counterIngredients} ingredients.");
            Console.Write($"The ingredients are: ");
            Console.Write(string.Join(", ",listPropperIng));
            Console.WriteLine(".");
        }
    }
}
