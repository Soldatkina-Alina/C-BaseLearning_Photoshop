using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MyPhotoshop
{
    class GrayscaleFilter : PixelFilter
    {
        public override ParameterInfo[] GetParameters()
        {
            return new ParameterInfo[0];
        }

        public override string ToString()
        {
            return "Черно-белая гамма";
        }

        public override Photo Process(Photo original, double[] parameters)
        {
            return ProcessPixel(original, parameters, GrayFilter);
        }

        public Pixel GrayFilter(Pixel original, double[] parameters)
        {
            int gray = (original.color.R + original.color.G + original.color.B) / 3;
            return new Pixel(Color.FromArgb(gray, gray, gray));
        }

    }
}
