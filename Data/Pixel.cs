using System;
using System.Drawing;

namespace MyPhotoshop
{
    public class Pixel
    {
        public Color color = new Color();

        public Pixel(Color color)
        {
            this.color = color;
        }

        public Pixel getNewPixelColor(double parameter)
        {
            parameter = parameter >= 1 ? 1 : parameter;
            return new Pixel(Color.FromArgb((int)(this.color.R * parameter), (int)(this.color.G * parameter), (int)(this.color.B * parameter)));
        }
    }
}
