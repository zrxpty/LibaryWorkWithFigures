using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures.Main;

namespace Figures
{
	public class Circle : Figure
	{
		public Vector2D Position { get; }
		public double Radius { get; }

		public Circle(float x, float y, double radius)
		{
			Position = new Vector2D(x, y);
			Radius = radius;
			Validate();
		}

		protected sealed override void Validate()
		{
			if (Radius < 0)
			{
				throw new ArgumentException("Radius cannot be negative");
			}
		}
		
		protected override double CalculateSquare()
		{
			return Math.PI * Math.Pow(Radius, 2);
		}
	}
}
