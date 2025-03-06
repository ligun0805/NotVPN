using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTVPN.Utils
{
	public static class UIHelper
	{
		public static void MakeTransparent(Control ctrl)
		{
			if (ctrl is Button btn)
			{
				btn.FlatStyle = FlatStyle.Flat;
				btn.BackColor = Color.Transparent;
				btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
				btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
				btn.FlatAppearance.BorderSize = 0;
			}
			else if (ctrl is Panel || ctrl is Label || ctrl is GroupBox)
			{
				ctrl.BackColor = Color.Transparent;
			}
		}

		public static void MakePanelAsGesture(Panel panel)
		{
			SwipeGestureHelper swipeGestureHelper = new SwipeGestureHelper();
			panel.AutoScroll = false;
			swipeGestureHelper.AttachToPanel(panel);
		}

		public static GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
		{
			GraphicsPath path = new GraphicsPath();
			int diameter = radius;

			if (radius > 0)
			{
				path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Top-left
				path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // Top-right
				path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Bottom-right
				path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // Bottom-left
				path.CloseFigure();
			}
			else
			{
				path.AddRectangle(rect);
			}

			return path;
		}
	}

	public class SwipeGestureHelper
	{
		private Point _startPoint;
		private bool _isSwiping = false;
		private const int SwipeThreshold = 10; // Minimum distance for a swipe
		private const int ScrollAmount = 30; // Amount to scroll per swipe
		private const int ScrollSteps = 10; // Number of steps for smooth scrolling
		private const int ScrollDelay = 10;
		public void AttachToPanel(Panel panel)
		{
			panel.MouseDown += Panel_MouseDown;
			panel.MouseMove += Panel_MouseMove;
			panel.MouseUp += Panel_MouseUp;
		}

		private void Panel_MouseDown(object sender, MouseEventArgs e)
		{
			_startPoint = e.Location;
			_isSwiping = true;
		}

		private void Panel_MouseMove(object sender, MouseEventArgs e)
		{
			if (_isSwiping)
			{
				int deltaX = e.Location.X - _startPoint.X;
				int deltaY = e.Location.Y - _startPoint.Y;

				if (Math.Abs(deltaX) > SwipeThreshold || Math.Abs(deltaY) > SwipeThreshold)
				{
					Panel panel = sender as Panel;
					string direction = GetSwipeDirection(deltaX, deltaY);
					ScrollPanel(panel, direction);
					_isSwiping = false; // Reset swipe state
				}
			}
		}

		private void Panel_MouseUp(object sender, MouseEventArgs e)
		{
			_isSwiping = false;
		}

		private string GetSwipeDirection(int deltaX, int deltaY)
		{
			if (Math.Abs(deltaX) > Math.Abs(deltaY))
			{
				return deltaX > 0 ? "Right" : "Left";
			}
			else
			{
				return deltaY > 0 ? "Down" : "Up";
			}
		}

		private void ScrollPanel(Panel panel, string direction)
		{
			int deltaX = 0;
			int deltaY = 0;

			switch (direction)
			{
				case "Right":
					deltaX = -ScrollAmount;
					break;
				case "Left":
					deltaX = ScrollAmount;
					break;
				case "Down":
					deltaY = -ScrollAmount;
					break;
				case "Up":
					deltaY = ScrollAmount;
					break;
			}

			foreach (Control control in panel.Controls)
			{
				control.Location = new Point(control.Location.X + deltaX, control.Location.Y + deltaY);
			}

			//for (int i = 0; i < ScrollSteps; i++)
			//{
			//	foreach (Control control in panel.Controls)
			//	{
			//		control.Location = new Point(control.Location.X + deltaX / ScrollSteps, control.Location.Y + deltaY / ScrollSteps);
			//	}
			//	await Task.Delay(ScrollDelay);

			//}
		}
	}
}
