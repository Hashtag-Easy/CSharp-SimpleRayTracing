using RayTracing.Interfaces;
using System.Drawing;
using System.Windows.Controls;

namespace RayTracing.Models
{
	public class Line : IDrawable
	{
		public Point Point1 { get; set; }
		public Point Point2 { get; set; }

		public Line(double x1, double y1, double x2, double y2)
			: this(new Point(x1, y1), new Point(x2, y2))
		{
		}

		public Line(Point point1, Point point2)
		{
			Point1 = point1;
			Point2 = point2;
		}

		public void Draw(ref Canvas canvas)
		{

		}
	}
}
