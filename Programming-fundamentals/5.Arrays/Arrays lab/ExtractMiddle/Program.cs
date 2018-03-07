using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = arr.Length;
            if (counter==1)
                Console.WriteLine("{{ {0} }}",arr[0]);
            else if(counter % 2 == 0)
            {
                Console.WriteLine("{{ {0}, {1} }}", arr[(counter-2)/2], arr[(counter - 2) / 2 +1]);
            }
            else if (counter % 2 != 0)
            {
                Console.WriteLine("{{ {0}, {1}, {2} }}", arr[(counter /2)-1], arr[(counter / 2)], arr[(counter / 2)+1]);
            }
        }
    }
}
