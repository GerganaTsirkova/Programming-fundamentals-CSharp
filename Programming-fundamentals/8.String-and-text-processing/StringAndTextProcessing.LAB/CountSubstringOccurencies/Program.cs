using System;

namespace CountSubstringOccurencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();
            string inputSearch = Console.ReadLine().ToLower();
            char[] arrInput = inputText.ToCharArray();
            int countOccurencies = 0;
            int index = -1;
            while(true)
            {
                index = inputText.IndexOf(inputSearch,index+1);
                if(index==-1)
                {
                    break;
                }
                else
                {
                    countOccurencies++;
                }
            }
            Console.WriteLine(countOccurencies);
        }
    }
}
