using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MyPhotoshop
{
    class GrayscaleFilter : PixelFilter
    {
        public GrayscaleFilter() : base(new GrayscaleParameters())
        {
        }

        public override string ToString()
        {
            return "Черно-белая гамма";
        }

        public override Pixel ProcessPixel(Pixel original, IParameters parameters)
        {
            int gray = (original.color.R + original.color.G + original.color.B) / 3;
            return new Pixel(Color.FromArgb(gray, gray, gray));
        }
    }
}
