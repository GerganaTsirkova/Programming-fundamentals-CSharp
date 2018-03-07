using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRecipe
{
    class Program
    {
        private static void CashRecipeHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("{0}", new string('-', 30));
        }

        private static void CashRecieptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        private static void CashRecieptEnd()
        {
            char a = '\u00A9';
            Console.WriteLine("{0}", new string('-', 30));
            Console.Write(a);
            Console.WriteLine(" SoftUni");
        }
        static void Main(string[] args)
        {

            CashRecipeHeader();
            CashRecieptBody();
            CashRecieptEnd();
        }
        


    }
}
