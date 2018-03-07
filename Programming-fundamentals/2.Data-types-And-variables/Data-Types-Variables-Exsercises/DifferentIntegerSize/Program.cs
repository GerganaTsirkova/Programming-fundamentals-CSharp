using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DifferentIntegerSize
{
    class Program
    {
        static void Main(string[] args)
        {

            string num = Console.ReadLine();

            bool isNum = BigInteger.TryParse(num, out BigInteger number);
            int byteNumber = 0;
            int sByteNum = 0;
            int shortNum = 0;
            int ushortNum = 0;
            int intNum = 0;
            int uIntNum = 0;
            int longNum = 0;

            if (isNum == true)
            {
                if ((number >= 0) && (number <= 255))
                    byteNumber++;
                if ((number >= -128) && (number <= 127))
                    sByteNum++;
                if ((number >= -32768) && (number <= 32767))
                    shortNum++;
                if ((number >= 0) && (number <= 65535))
                    ushortNum++;
                if ((number >= -2147483648) && (number <= 2147483647))
                    intNum++;
                if ((number >= 0) && (number <= 4294967295))
                    uIntNum++;
                if ((number >= -9223372036854775808) && (number <= 9223372036854775807))
                    longNum++;

            }
            if ((byteNumber != 0) || (sByteNum != 0) || (shortNum != 0) || (ushortNum != 0) || (intNum != 0) || (uIntNum != 0) || (longNum != 0))
            {
                Console.WriteLine($"{number} can fit in:");
                if (byteNumber > 0)
                {
                    Console.WriteLine("* byte");
                }
                if (sByteNum > 0)
                {
                    Console.WriteLine("* sbyte");
                }
                if (shortNum > 0)
                {
                    Console.WriteLine("* short");
                }
                if (ushortNum > 0)
                {
                    Console.WriteLine("* ushort");
                }
                if (intNum > 0)
                {
                    Console.WriteLine("* int");
                }
                if (uIntNum > 0)
                {
                    Console.WriteLine("* uint");
                }
                if (longNum > 0)
                {
                    Console.WriteLine("* long");
                }


            }
            else
            {
                Console.WriteLine($"{number} can't fit in any type");

            }
        }
    }
}

