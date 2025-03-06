using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace NOTVPN.Template
{
	[ToolboxItem(true)]
	public partial class RoundedDigitTextBox : UserControl
	{
		private int _cornerRadius = 10;
		private Color _backColor = Color.HotPink;

		[Category("Appearance")]
		public int CornerRadius
		{
			get { return _cornerRadius; }
			set { _cornerRadius = value; Invalidate(); }
		}

		[Category("Appearance")]
		public Color BackColorCustom
		{
			get { return _backColor; }
			set { _backColor = value; Invalidate(); }
		}

		public RoundedDigitTextBox()
		{
			InitializeComponent();
			this.Width = 70;this.Height = 66;
			SetStyle(ControlStyles.AllPaintingInWmPaint
					 | ControlStyles.OptimizedDoubleBuffer
					 | ControlStyles.ResizeRedraw
					 | ControlStyles.UserPaint, true);

			_innerTextBox.KeyPress += InnerTextBox_KeyPress;
			_innerTextBox.Multiline = false;
		}

		public override Font Font
		{
			get { return base.Font; }
			set
			{
				base.Font = value;
				//_innerTextBox.Font = value;
			}
		}

		private void UpdateControlHeight()
		{
			if (_innerTextBox.Multiline == false)
			{
				int txtHeight = TextRenderer.MeasureText("8", this.Font).Height + 1;
				_innerTextBox.Multiline = true;
				_innerTextBox.MinimumSize = new Size(0, txtHeight);
				_innerTextBox.Multiline = false;

				this.Height = txtHeight + this.Padding.Top + this.Padding.Bottom;
			}
		}

		private void InnerTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Allow control characters (Backspace etc.) and digits only
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		// Expose the inner Text property if desired
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public override string Text
		{
			get
			{
				return _innerTextBox?.Text;
			}
			set
			{
				if (_innerTextBox != null)
				{
					_innerTextBox.Text = value;
				}
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

			// Draw the rounded rectangle background
			using (GraphicsPath path = GetRoundedRectanglePath(ClientRectangle, _cornerRadius))
			{
				using (SolidBrush brush = new SolidBrush(_backColor))
				{
					e.Graphics.FillPath(brush, path);
				}
			}
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			//_innerTextBox.Location = new Point(5, 5);
			
			Invalidate(); // Redraw the background
		}

		private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
		{
			GraphicsPath path = new GraphicsPath();
			int diameter = radius * 2;
			Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));

			// Top-left arc
			path.AddArc(arcRect, 180, 90);

			// Top-right arc
			arcRect.X = rect.Right - diameter;
			path.AddArc(arcRect, 270, 90);

			// Bottom-right arc
			arcRect.Y = rect.Bottom - diameter;
			path.AddArc(arcRect, 0, 90);

			// Bottom-left arc
			arcRect.X = rect.Left;
			path.AddArc(arcRect, 90, 90);

			path.CloseFigure();
			return path;
		}
	}
}
