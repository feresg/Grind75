namespace Week1;

public static class Stock
{
    public static int MaxProfit(int[] prices)
    {
        var maxProfit = 0;
        var purchasePrice = prices[0];
        for (var i = 0; i < prices.Length; i++)
        {
            if (prices[i] < purchasePrice)
            {
                purchasePrice = prices[i];
            }

            else if (prices[i] - purchasePrice > maxProfit)
            {
                maxProfit = prices[i] - purchasePrice;
            }

        }
        return maxProfit;
    }
    
}