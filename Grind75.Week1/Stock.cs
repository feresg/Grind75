namespace Week1;

public static class Stock
{
    public static int MaxProfit(int[] prices)
    {
        var maxProfit = 0;
        var purchasePrice = prices[0];
        foreach (var price in prices)
        {
            if (price < purchasePrice)
            {
                purchasePrice = price;
            }

            else if (price - purchasePrice > maxProfit)
            {
                maxProfit = price - purchasePrice;
            }
        }

        return maxProfit;
    }
}