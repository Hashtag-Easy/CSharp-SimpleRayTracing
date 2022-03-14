using RayTracing.Interfaces;
using RayTracing.Models;
using System.Drawing;
using System.Windows.Controls;

namespace RayTracing
{
	public class Rays : IDrawable
	{
		#region Default Values

		private const int numberOfLinesDefault = 20;
		private const double lineThicknessDefault = 2;
		private const double lineRangeDefault = 9999;
		private const double centerDiameterDefault = 10;
		private const RaysCenterEffect raysCenterEffectDefault = RaysCenterEffect.None;
		private readonly Color lineColorDefault = Color.FromArgb(255, 255, 255);
		private readonly Color centerColorDefault = Color.FromArgb(255, 255, 255);

		#endregion

		private Point mousePosition;
		private readonly int numberOfLines;
		private readonly double lineThickness;
		private readonly double lineRange;
		private readonly Color lineColor;
		private readonly double centerDiameter;
		private readonly Color centerColor;
		private readonly RaysCenterEffect raysCenterEffect;

		public Rays(Point mousePosition)
			: this(mousePosition, null)
		{
		}

		public Rays(Point mousePosition, int? numberOfLines)
			: this(mousePosition, numberOfLines ?? null, null)
		{
		}

		public Rays(Point mousePosition, int? numberOfLines, double? lineThickness)
			: this(mousePosition, numberOfLines ?? null, lineThickness ?? null, null)
		{
		}

		public Rays(Point mousePosition, int? numberOfLines, double? lineThickness, double? lineRange)
			: this(mousePosition, numberOfLines ?? null, lineThickness ?? null, lineRange ?? null, null)
		{
		}

		public Rays(Point mousePosition, int? numberOfLines, double? lineThickness, double? lineRange, double? centerDiameter)
			: this(mousePosition, numberOfLines ?? null, lineThickness ?? null, lineRange ?? null, centerDiameter ?? null, null)
		{
		}

		public Rays(Point mousePosition, int? numberOfLines, double? lineThickness, double? lineRange, double? centerDiameter, RaysCenterEffect? raysCenterEffect)
		{
			this.mousePosition = mousePosition;
			this.numberOfLines = numberOfLines ?? numberOfLinesDefault;
			this.lineThickness = lineThickness ?? lineThicknessDefault;
			this.lineRange = lineRange ?? lineRangeDefault;
			this.centerDiameter = centerDiameter ?? centerDiameterDefault;
			this.raysCenterEffect = raysCenterEffect ?? raysCenterEffectDefault;
			this.lineColor = lineColorDefault;
			this.centerColor = centerColorDefault;
		}

		public void Draw(ref Canvas canvas)
		{
			Line[] lines = GetLines();
			Point center = GetCenter();

			foreach(var line in lines)
				canvas.Children.Add(line);

			canvas.Children.Add(center);
		}

		private Point GetCenter()
		{
			
			
			return new Point(mousePosition.X, mousePosition.Y);
		}

		private Line[] GetLines()
		{
			Line[] lines = new Line[numberOfLines];

			foreach(var line in lines)
			{

			}

			return lines;
		}
	}
}
