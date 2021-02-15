using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public abstract class PixelFilter : IFilter
    {
        public virtual ParameterInfo[] GetParameters()
        {
            throw new NotImplementedException();
        }

        public virtual Photo Process(Photo original, double[] parameters)
        {
            throw new NotImplementedException();
        }

        public Photo ProcessPixel(Photo original, double[] parameters, FilterProcess filterProcess)
        {
            var result = new Photo(original.width, original.height);
            for (int x = 0; x < result.width; x++)
                for (int y = 0; y < result.height; y++)
                    result[x, y] = filterProcess(original[x, y], parameters);

            return result;
        }
    }
}
