using RayTracing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace RayTracing
{
	public partial class MainWindow : Window
	{
		private const int frameRate = 144;
		
		public MainWindow()
		{
			InitializeComponent();
			InitCanvas();
		}

		private void InitCanvas()
		{
			DispatcherTimer dispatcherTimer = new();
			dispatcherTimer.Tick += MainDrawer;
			dispatcherTimer.Interval = new TimeSpan(0, 0, 1) / frameRate;
			dispatcherTimer.Start();
		}

		private void MainDrawer(object? sender, EventArgs e)
		{
			Point mousePosition = GetMousePosition(MainCanvas);
		}

		private Point GetMousePosition<T>(T obj) where T : IInputElement
		{
			Point point = Mouse.GetPosition(obj);

			return point;
		}
	}
}
