using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using NOTVPN.Utils;

namespace NOTVPN.Template
{
	[ToolboxItem(true)]
	public class CustomProgressBar : ProgressBar
	{
		public Color ProgressColor { get; set; } = Color.White; // Main Progress Color
		public Color AlternativeProgressColor { get; set; } = Color.FromArgb(85, 152, 255); // Alternate Stripes Color
		public Color ProgressContainerColor { get; set; } = Color.FromArgb(85, 152, 255); // Background Color
		public Color BorderColor { get; set; } = Color.FromArgb(85,152,255); // Border Color
		public Color ShadowColor { get; set; } = Color.White; // Shadow Color
		public int BorderRadius { get; set; } = 1; // Rounded Corners

		public CustomProgressBar()
		{
			this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
		}

		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
			//base.OnPaintBackground(pevent);
			pevent.Graphics.DrawImage(Parent.BackgroundImage,-Left,-Top,Parent.Width,Parent.Height);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			if (Width == 0 || Height == 0) return;
			using (Graphics g = e.Graphics)
			{
				g.SmoothingMode = SmoothingMode.AntiAlias;

				int progressWidth = (int)((float)Value / Maximum * Width);
				Rectangle rect = new Rectangle(0, 0, Width-2 , Height-2);
				Rectangle progressRect = new Rectangle(1, 1, progressWidth-2, Height - 3);
				Rectangle shadowRect = new Rectangle(4, 4, Width - 6, Height - 6);

				using (GraphicsPath path = UIHelper.GetRoundedRectangle(rect, BorderRadius))
				using (GraphicsPath progressPath = UIHelper.GetRoundedRectangle(progressRect, BorderRadius))
				using (GraphicsPath shadowPath = UIHelper.GetRoundedRectangle(shadowRect, BorderRadius))
				{
					// Draw Shadow
					//using (SolidBrush shadowBrush = new SolidBrush(ShadowColor))
					//{
					//	g.FillPath(shadowBrush, shadowPath);
					//}

					// Draw Background (Progress Container)
					using (SolidBrush bgBrush = new SolidBrush(ProgressContainerColor))
					{
						g.FillPath(bgBrush, path);
					}

					if (progressRect.Width != 0 && progressRect.Height != 0)
					{
						using (SolidBrush bgBrush = new SolidBrush(ProgressColor))
						{
							g.FillPath(bgBrush, progressPath);
						}

						//using (LinearGradientBrush progressBrush = new LinearGradientBrush(progressRect, ProgressColor, AlternativeProgressColor, LinearGradientMode.ForwardDiagonal))
						//{
						//	g.FillPath(progressBrush, progressPath);
						//}
					}
					// Draw Progress (with Striped Effect)


					// Draw Border
					using (Pen borderPen = new Pen(BorderColor, 1))
					{
						g.DrawPath(borderPen, path);
					}
				}
			}
		}
	}
}
