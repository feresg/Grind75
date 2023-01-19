namespace Week1;

public class FloodFill
{
    // does not pass
    public static int[][] Fill(int[][] image, int sr, int sc, int color) {
        if(image[sr][sc] == color) return image;

        image[sr][sc] = color;

        if (sr > 0) image = Fill(image, sr - 1, sc, color);
        if (sc > 0) image = Fill(image, sr, sc - 1, color);
        if (sr < image.Length - 1) image = Fill(image, sr + 1, sc, color);
        if (sc < image[sr].Length - 1) image = Fill(image, sr, sc+1, color);

        return image;
    }

}