using System;
class PriceChangeAlert
{ 

    static void Main()
    {
        int inputNumbers = int.Parse(Console.ReadLine());
        double allowedBorder = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < inputNumbers - 1 ; i++)
        {
            double price = double.Parse(Console.ReadLine());

            double difference = Percentage(lastPrice, price);
            bool trueOrFalse = GetDifference(difference, allowedBorder);
            string message = GetMessage(price, lastPrice, difference, trueOrFalse);

            Console.WriteLine(message);
            lastPrice = price;
        }
    }
    static string GetMessage(double price, double lastPrice, double difference, bool trueOrFalse)
    {
        string message = string.Empty;
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", price);
        }
        else if (!trueOrFalse)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, price, difference * 100);
        }
        else if (trueOrFalse && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, price, difference * 100);
        }
        else if (trueOrFalse && (difference < 0))
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, price, difference * 100);
        return message;
    }
    static bool GetDifference(double difference, double allowedBorder)
    {
        if (Math.Abs(difference) >= allowedBorder)
        {
            return true;
        }
        return false;
    }
    static double Percentage(double lastPrice, double Price)
    {
        double result = (Price - lastPrice) / lastPrice ;
        return result;
    }
}
