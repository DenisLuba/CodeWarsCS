using System.Security.AccessControl;

namespace CodeWars;

public class MakeSpiral
{
    static readonly int Gap = 2;

    public static int[,] Spiralize(int size)
    {
        var spiral = new int[size,size];
        int layer = 0, top = 0, left = 0, bottomExclusive = size, rightExclusive = size;

        while (bottomExclusive > top)
        {

            FillRow(spiral, top, Math.Max(0, left - Gap), rightExclusive); // top side
            FillColumn(spiral, left, top + Gap, bottomExclusive); // left side
            FillColumn(spiral, rightExclusive - 1, top, bottomExclusive); // right side

            if (bottomExclusive - top == Gap) break;

            FillRow(spiral, bottomExclusive - 1, left, rightExclusive); // bottom side

            layer += Gap;

            top = left = layer;
            bottomExclusive = rightExclusive = size - layer;
        }

        return spiral;
    }

    private static void FillRow(int[,] spiral, int row, int start, int end)
    {
        for (int i = start; i < end; i++)
        {
            spiral[row, i] = 1;
        }
    }

    private static void FillColumn(int[,] spiral, int column, int start, int end)
    {
        for (int i = start; i < end; i++)
        {
            spiral[i, column] = 1;
        }
    }
}
