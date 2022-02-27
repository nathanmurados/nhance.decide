using System.Drawing;

namespace NhanceMap.Services;

public static class PercentColorRanges
{ 
    private static string HexConverter(System.Drawing.Color c)
    {
        return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
    } 
    public static string GetColor(double rangeStart /*Complete Red*/, double rangeEnd /*Complete Green*/, double actualValue)
    {
        var color = Color.Black;

        if (rangeStart < rangeEnd)
        {
            var max = rangeEnd - rangeStart; // make the scale start from 0
            var value = actualValue - rangeStart; // adjust the value accordingly

            var red = (255 * value) / max;
            var green = 255 - red;

            color = Color.FromArgb((byte)red, (byte)green, (byte)0);
        }
        return HexConverter(color);
    }
}

