namespace Week1.UnitTests;

public class StockShould
{
    [Theory]
    [InlineData(new int[] {7,6,4,3,1})]
    public void MaxProfit_WhenNoProfitPossible_ReturnZero(int[] prices)
    {
        Assert.Equal(0, Stock.MaxProfit(prices));
    }
    
    [Theory]
    [InlineData(new int[] {7,1,5,3,6,4}, 5)]
    public void MaxProfit_WhenProfitIsPossible_ReturnMaxProfit(int[] prices, int expectedMaxProfit)
    {
        Assert.Equal(expectedMaxProfit, Stock.MaxProfit(prices));
    }
}