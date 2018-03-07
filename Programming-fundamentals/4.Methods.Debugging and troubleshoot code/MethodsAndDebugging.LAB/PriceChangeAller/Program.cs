using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double treshold = double.Parse(Console.ReadLine());
        treshold *= 100;
        double price = double.Parse(Console.ReadLine());
        for (int i = 0; i < n-1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = DifferenceInPrice(price, currentPrice);
            bool isSignificantDifference = KindOfDiff(treshold,difference);
            string messageOutput = Output(currentPrice, price, difference,treshold, isSignificantDifference);
            Console.WriteLine(messageOutput);
            price = currentPrice;
            
        }
    }
    static string Output(double currentPrice, double lastPrice, double difference,double treshold, bool trueOrFalse)
    {
        string outputMesage = "";
        if (difference == 0)
        {
            outputMesage = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!trueOrFalse)
        {
            outputMesage = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
        }
        else if (trueOrFalse && (difference > 0))
        {
            outputMesage = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
        }
        else if (trueOrFalse && (difference < 0))
        {
            outputMesage = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
        }
        return outputMesage;
    }
    static bool KindOfDiff(double treshold, double difference)
    {
        if (Math.Abs(treshold) <= Math.Abs(difference))
        {
            return true;
        }
        return false;
    }

    static double DifferenceInPrice(double oldPrice, double newPrice)
    {
        return ((newPrice - oldPrice) / oldPrice)*100;
    }
}
