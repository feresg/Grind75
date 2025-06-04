namespace Week1;

public static class FloodFill
{
    // DOES NOT PASS
    public static int[][] Fill(int[][] image, int sr, int sc, int color)
    {
        var colorBefore = image[sr][sc];
        if (colorBefore != color)
        {
            return Fill(image, sr, sc, colorBefore, color);
        }

        return image;
    }
    
    private static int[][] Fill(int[][] image, int sr, int sc, int oldColor, int color) {
        if (image[sr][sc] == oldColor)
        {
            image[sr][sc] = color;

            if (sr > 0) image = Fill(image, sr - 1, sc, oldColor, color);
            if (sc > 0) image = Fill(image, sr, sc - 1, oldColor, color);
            if (sr < image.Length - 1) image = Fill(image, sr + 1, sc, oldColor, color);
            if (sc < image[sr].Length - 1) image = Fill(image, sr, sc+1, oldColor, color);
        }

        return image;
    }
}