using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTVPN.Template
{
	public enum SepStype
	{
		Horizental,
		Vertical
	}

	[ToolboxItem(true)]
	public class Sep : Control
	{
		private Color _lineColor;
		private int _sepWidth;
		private Pen _linePen;
		public SepStype style { get; set; }

		public Color lineColor
		{
			get { return _lineColor; }
			set {
				_lineColor = value;
				this._linePen = new Pen(this.lineColor, _sepWidth);
				this._linePen.Alignment = PenAlignment.Inset;

				Refresh();
			}
		}
		public Sep()
		{
			this.lineColor = Color.LightGray;
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			style = SepStype.Vertical;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this._linePen != null)
			{
				this._linePen.Dispose();
				this._linePen = null;
			}

			base.Dispose(disposing);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			var g = e.Graphics;
			
			g.SmoothingMode = SmoothingMode.AntiAlias;

			if(style == SepStype.Vertical)
			{
				int x = this.Width / 2;
				g.DrawLine(_linePen, x, 0, x, this.Height);
			}
			else if(style == SepStype.Horizental)
			{
				int x = this.Height / 2;
				g.DrawLine(_linePen, 0, x, this.Width,x);
			}
			

			base.OnPaint(e);
		}
		public int lineWidth
		{
			get { return _sepWidth; }
			set { 
				_sepWidth = value;
				this._linePen = new Pen(this.lineColor, _sepWidth);
				this._linePen.Alignment = PenAlignment.Inset;

				Refresh();
			}
		}
	}
}
