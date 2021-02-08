using System;

namespace MyPhotoshop
{
	public class Photo
	{
		public readonly int width;
		public readonly int height;

		public Photo(int width, int height)
        {
			this.width = width;
			this.height = height;
        }

		Pixel[,] data;

		public Pixel this[int x, int y]
        {
			get { return data[x, y]; }
			set { if (data == null) 
					data = new Pixel[width, height]; 
				data[x, y] = value; }
        }

	}
}

