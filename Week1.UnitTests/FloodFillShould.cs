namespace Week1.UnitTests;

public class FloodFillShould
{
    [Fact]
    public void Fill_ReturnValidResult()
    {
        int[][] image = { new[] { 1, 1, 1 }, new[] { 1, 1, 0 }, new[] { 1, 0, 1 } };
        int[][] expectedImage = { new[] { 2, 2, 2 }, new[] { 2, 2, 0 }, new[] { 2, 0, 1 } };
        var (sr, sc, color) = (1, 1, 2);
        var modifiedImage = FloodFill.Fill(image, sr, sc, color);
        Assert.Equal(expectedImage, modifiedImage);
    }
}