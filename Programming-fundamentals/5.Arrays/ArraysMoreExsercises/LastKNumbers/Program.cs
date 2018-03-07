using System;

namespace LastKNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[len];
            array[0] = 1;

            for (int i = 1; i < len; i++)
            {
                int sum = 0;
                int counter = 0;
                for (int j = i; j >= 0 ; j--)
                {
                    sum += array[j];
                    counter++;
                    if(counter>k)
                    {
                        break;
                    }
                }
                array[i] = sum;
            }
            Console.WriteLine(string.Join(" ",array));
        }
    }
}
