using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int counter = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = i+1; j < arr.Count; j++)
                {
                    
                    if (arr.Contains(arr[i] + arr[j]))
                    {
                        counter++;
                        Console.WriteLine("{0} + {1} == {2}",arr[i],arr[j],arr[i]+arr[j]);
                    }
                }
            }
            if (counter==0)
                Console.WriteLine("No");
        }
    }
}
