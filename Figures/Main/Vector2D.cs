using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Main
{
	public struct Vector2D
	{
		public const double Tolerance = 0.0001;

		public Vector2D(float x, float y)
		{
			X = x;
			Y = y;
		}

		public float X { get; }
		public float Y { get; }
	}
}
