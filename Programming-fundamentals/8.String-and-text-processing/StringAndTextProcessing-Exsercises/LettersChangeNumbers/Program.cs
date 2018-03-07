using System;
using System.Linq;

namespace P08_Letters_Change_Numbers
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var sum = 0.0;


            for (int i = 0; i < input.Length; i++)
            {
                var currentString = input[i];


                string num = (currentString.Substring(1, currentString.Length - 2));
                for (int j = 0; j < num.Length; j++)
                {
                    if((num[i]>=65)&&(num[i]<=90)||(num[i]>=97)&&(num[i]<=122))
                    {
                        num = num.Substring(1, num[i]);
                    }
                }
                double number = double.Parse(num);
                var firstLetter = currentString[0];
                var firstLetterPosition = FindLetterPosinionInAlphabet(firstLetter);

                if (IsUpper(firstLetter))
                {
                    number /= firstLetterPosition;
                }
                else
                {
                    number *= firstLetterPosition;
                }

                var lastLetter = currentString[currentString.Length - 1];
                var lastLetterPosition = FindLetterPosinionInAlphabet(lastLetter);

                if (IsUpper(lastLetter))
                {
                    number -= lastLetterPosition;
                }

                else
                {
                    number += lastLetterPosition;
                }

                sum += number;

            }


            Console.WriteLine($"{sum:f2}");

        }

        private static bool IsUpper(char letter)
        {
            bool isUpper = letter >= 65 && letter <= 90;
            return isUpper;

        }

        private static int FindLetterPosinionInAlphabet(char letter)
        {
            bool isUpper = letter >= 65 && letter <= 90;
            var LetterPositioninAlphabet = 0;

            if (isUpper)
            {
                return LetterPositioninAlphabet = letter - 65 + 1;
            }

            else
            {
                return LetterPositioninAlphabet = letter - 97 + 1;
            }
        }
    }
}