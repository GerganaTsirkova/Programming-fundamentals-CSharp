using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTriangle
{
    class Program
    {
        

        static void PrintLineFirst(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }
        static void PrintLineSecond(int start, int end)

        {
            for (int i = end; i >= start; i--)
            {
                for (int j = 1; j <=i-1; j++)
                {
                    Console.Write(j + " ");
                    
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintLineFirst(1, n);
            PrintLineSecond(1,n);

        }

        
       
    }
}
