using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToBolean
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool newBool = Convert.ToBoolean(input);
            if (input == "true")
            {
                newBool = Convert.ToBoolean(input);
                Console.WriteLine("Yes");
            }
            else if (input == "false")
            {
                newBool = Convert.ToBoolean(input);
                newBool = false;
                Console.WriteLine("No");
            }
        }
    }
}

