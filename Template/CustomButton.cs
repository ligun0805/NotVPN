using NOTVPN.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTVPN.Template
{
	[ToolboxItem(true)]
	public class CustomButton : Label
	{
		Image _bg = null;
		Color _color = Color.Transparent;
		public Color BorderColor { get; set; } = Color.Transparent;		
		public int BorderThickness { get; set; } = 1;		
		public int CornerRadius { get; set; } = 0;

		// Define the event
		public event EventHandler Clicked;

		public CustomButton()
		{
			this.FlatStyle = FlatStyle.Flat;
			SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
			this.MouseClick += new MouseEventHandler(OnClick);
			this.AutoSize = false;
			this.TextAlign = ContentAlignment.MiddleCenter;
			this.BackColor = Color.Transparent;
		}

		// Override the OnPaint method to paint the background image
		protected override void OnPaint(PaintEventArgs e)
		{
			Rectangle rect;
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			if (CornerRadius > 0 && BorderThickness > 0 && BorderColor != Color.Transparent)
			{
				rect = new Rectangle(0, 0, Width - 2, Height - 2);
				using (GraphicsPath path = UIHelper.GetRoundedRectangle(rect, CornerRadius))
				{
					e.Graphics.SetClip(path);
					using (SolidBrush bgBrush = new SolidBrush(BGRoundColor))
					{
						e.Graphics.FillPath(bgBrush, path);
					}
					if (BGImage != null)
					{
						e.Graphics.SetClip(path);
						// Draw the background image, fitting it to the label size
						e.Graphics.DrawImage(BGImage,rect);
					}

					using (Pen borderPen = new Pen(BorderColor, BorderThickness))
					{

						e.Graphics.DrawPath(borderPen, path);
					}
				}
			}else if (BGImage != null)
			{
				// Draw the background image, fitting it to the label size
				e.Graphics.DrawImage(BGImage, 0, 0, this.Width, this.Height);
			}

			base.OnPaint(e);
		}

		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
			base.OnPaintBackground(pevent);
			//if (Parent.BackgroundImage != null)
			//{
			//	pevent.Graphics.DrawImage(Parent.BackgroundImage, -Left, -Top, Parent.Width, Parent.Height);
			//}
		}

		// Mouse click event handler
		private void OnClick(object sender, MouseEventArgs e)
		{
			// Trigger the Click event
			Clicked?.Invoke(this, EventArgs.Empty);
		}

		// Optional: Allow setting background image as a property
		public Image BGImage
		{
			get { return _bg; }
			set {_bg = value; }
		}

		public Color BGRoundColor
		{
			get { return _color; }
			set { _color = value; }
		}
	}
}
