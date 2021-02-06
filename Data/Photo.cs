using System;
using System.Drawing;

namespace MyPhotoshop
{
	public class Photo
	{
		public int width;
		public int height;
		//public double[,,] data;
		public Pixel[,] data;
	}

	public class Pixel
    {
		public Color color = new Color();

		public Pixel(Color color)
        {
			this.color = color;
        }
    }
}

