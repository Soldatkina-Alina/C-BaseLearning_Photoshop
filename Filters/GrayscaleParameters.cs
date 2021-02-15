using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public class GrayscaleParameters : IParameters
    {
        public ParameterInfo[] GetDiscription()
        {
            return new ParameterInfo[0];
        }

        public void SetParameters(double[] parameters)
        {
        }
    }
}
