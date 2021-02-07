using System;
using System.Drawing;

namespace MyPhotoshop
{
    public class Pixel
    {
        public Color color;

        public Pixel(Color color)
        {
            this.color = color;
        }

        public static Color operator *(Pixel pixel, double parameter)
        {
            return Color.FromArgb((int)(pixel.color.R * parameter), (int)(pixel.color.G * parameter), (int)(pixel.color.B * parameter));
        }

        public Pixel getNewPixelColor(double parameter)
        {
            parameter = parameter >= 1 ? 1 : parameter;
            return new Pixel(Color.FromArgb((int)(this.color.R * parameter), (int)(this.color.G * parameter), (int)(this.color.B * parameter)));
        }
    }
}
