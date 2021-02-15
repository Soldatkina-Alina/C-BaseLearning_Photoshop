using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public abstract class ParametrizedFilter : IFilter
    {
        IParameters parameters;
        public ParametrizedFilter(IParameters parameters)
        {
            this.parameters = parameters;
        }
        public ParameterInfo[] GetParameters()
        {
            return parameters.GetDiscription();
        }

        public abstract Photo Process(Photo original, IParameters parameters);

        public Photo Process(Photo photo, double[] values)
        {
            parameters.SetParameters(values);
            return Process(photo, parameters);
        }
    }
}
