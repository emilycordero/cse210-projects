using System;

public abstract class Shape
{
		private string _color;

		public Shape(string color)
		{
			_color = color;
		}

		public string GetColor();
		{
			return _color;
		}

		public void SetColor(string color) 
		{
			_color = color;
		}

	// no need to have default set it as abstract instead of virtual

	public abstract double GetArea();
	
}
