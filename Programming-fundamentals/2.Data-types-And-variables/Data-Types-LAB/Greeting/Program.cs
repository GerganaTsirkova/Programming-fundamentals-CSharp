using System;

namespace _7.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {name} {surname}. You are {age} years old.");
        }
    }
}
