using System;

namespace _5.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isSpecial = true;
            for (int i = 1; i <= n; i++)
            {
                if(i<12)
                {
                    if((i==5)||(i==7))
                    {
                        isSpecial = true;
                        Console.WriteLine($"{i} -> {isSpecial}");
                    }
                    else
                    {
                        isSpecial = false;
                        Console.WriteLine($"{i} -> {isSpecial}");
                    }

                }
                else
                {
                    int sum = 0;
                    int num = i;
                    while(num % 10 != 0)
                    {
                        sum += num % 10;
                        num /= 10;
                    }
                    if(((sum==5)||(sum==7)||(sum==11))||((num==50)||(num==70)))
                    {
                        isSpecial = true;
                        Console.WriteLine($"{i} -> {isSpecial}");
                    }
                    else
                    {
                        isSpecial = false;
                        Console.WriteLine($"{i} -> {isSpecial}");
                    }
                }
            }
        }
    }
}
