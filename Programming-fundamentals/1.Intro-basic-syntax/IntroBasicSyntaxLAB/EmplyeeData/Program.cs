using System;

namespace EmplyeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine().PadLeft(8, '0');
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {id}");
            Console.WriteLine($"Salary: {salary:f2}");
        }
    }
}
