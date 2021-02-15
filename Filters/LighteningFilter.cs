using System;
using System.Drawing;

namespace MyPhotoshop
{
	public class LighteningFilter : PixelFilter
	{
		public override ParameterInfo[] GetParameters()
		{
			return new []
			{
				new ParameterInfo { Name="Коэффициент", MaxValue=10, MinValue=0, Increment=0.1, DefaultValue=1 }
				
			};
		}
		
		public override string ToString ()
		{
			return "Осветление/затемнение";
		}
		
		public override Photo Process(Photo original, double[] parameters)
		{
			return ProcessPixel(original, parameters, LightFilter);
		}

		public Pixel LightFilter(Pixel original, double[] parameters)
        {
			return original * parameters[0];
		}

		private int ToChannel(double v)
        {
            throw new NotImplementedException();
        }
    }
}

