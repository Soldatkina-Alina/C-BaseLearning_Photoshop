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

        public static Pixel operator *(Pixel pixel, double parameter)
        {
            return new Pixel(Color.FromArgb(Trim(pixel.color.R * parameter), Trim(pixel.color.G * parameter), Trim(pixel.color.B * parameter)));
        }
    }
}
