using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            return original.PixelBlackWhiteColor;
        }

    }
}
