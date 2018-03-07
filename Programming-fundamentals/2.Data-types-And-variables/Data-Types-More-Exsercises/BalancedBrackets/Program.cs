using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = "";
            int onlyNumbers = 0;
            int unbalanced = 0;
            int openBrackets = 0;
            for (int i = 0; i <n; i++)
            {
                input = Console.ReadLine();
                if((input != "(")&&(input !=")"))
                {
                    if ((i == n - 1) && (openBrackets == 1))
                    {
                        unbalanced++;
                    }
                    onlyNumbers++;
                    continue;
                }
                else if (input=="(")
                {
                    openBrackets++;
                }
                else if (input==")")
                {
                    if(openBrackets==1)
                    {

                        openBrackets = 0;
                    }
                    else
                    {
                        unbalanced++;
                    }
                }
                if (openBrackets==2)
                {
                    openBrackets = 0;
                    unbalanced++;
                }
            }
            if ((unbalanced>0)||(onlyNumbers==n))
            {
                Console.WriteLine("UNBALANCED");
            }
            else
            {
                Console.WriteLine("BALANCED");
            }
        }
    }
}
