using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    class GrayscaleFilter : IFilter
    {
        public ParameterInfo[] GetParameters() => null;

        public override string ToString()
        {
            return "Черно-белая гамма";
        }

        public Photo Process(Photo original, double[] parameters)
        {
            var result = new Photo(original.width, original.height);
            for (int x = 0; x < result.width; x++)
                for (int y = 0; y < result.height; y++)
                    result[x, y] = original[x, y].getNewPixelBlackWhiteColor();
            return result;
        }
    }
}
