﻿using System;

public class Square : Shape
{
	private double _side;
	public Square()
	{
		_side = side;
	}

	public override double GetArea()
	{
		return _side * _side;
	}
}
