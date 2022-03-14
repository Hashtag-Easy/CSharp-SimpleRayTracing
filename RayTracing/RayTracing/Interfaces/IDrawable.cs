using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RayTracing.Interfaces
{
	public interface IDrawable
	{
		public void Draw(ref Canvas canvas);
	}
}
