using System;
using System.Drawing;

namespace MyPhotoshop
{
    public class Pixel
    {
        public Color color;
        readonly static int minPixel = 0;
        readonly static int maxPixel = 255;

        public Pixel(Color color)
        {
            this.color = color;
        }

        public static int Trim(double value)
        {
            if (value >= maxPixel) return maxPixel;
            if (value < minPixel) return minPixel;
            return (int)value;
        }
        public static Color operator *(Pixel pixel, double parameter)
        {
            return Color.FromArgb((int)(pixel.color.R * parameter), (int)(pixel.color.G * parameter), (int)(pixel.color.B * parameter));
        }

        public Pixel getNewPixelColor(double parameter)
        {
            parameter = parameter >= 1 ? 1 : parameter;
            return new Pixel(Color.FromArgb(Trim(this.color.R * parameter), Trim(this.color.G * parameter), Trim(this.color.B * parameter)));
        }

        public Pixel getNewPixelBlackWhiteColor()
        {
            int c = (this.color.R + this.color.G + this.color.B) / 3;
            // собираем новый пиксель по частям (по каналам)
            UInt32 newPixel = 0xFF000000 | ((UInt32)c << 16) | ((UInt32)c << 8) | ((UInt32)c);
            return new Pixel(Color.FromArgb((int)newPixel));
        }
    }
}
