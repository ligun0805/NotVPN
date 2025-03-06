using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NOTVPN.Template
{
	public enum ButtonState
	{
		Off,
		Loading,
		On
	}

	[ToolboxItem(true)]
	public class CircularProgressButton : Label
	{
		private Timer _timer;
		private int _progress = 0; // 0..100 for loading arc
		private ButtonState _state;

		public int border { get; set; }
		Image _bg = null;
		public Image Icon
		{
			get { return _bg; }
			set { _bg = value; }
		}

		public CircularProgressButton()
		{
			//this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			//this.BackColor = Color.Transparent;

			// For smooth edges, double-buffer, etc.
			this.SetStyle(ControlStyles.ResizeRedraw
						  | ControlStyles.OptimizedDoubleBuffer
						  | ControlStyles.AllPaintingInWmPaint
						  | ControlStyles.UserPaint, true);

			// Set default size
			this.Size = new Size(100, 100);
			border = 10;
			// Setup a Timer to animate the loading progress
			_timer = new Timer();
			_timer.Interval = 50; // ms: adjust speed as desired
			_timer.Tick += (s, e) =>
			{
				_progress += 1; // increment progress
				if (_progress > 100)
				{
					_progress = 0;
					// Once we reach 100%, we consider loading finished
					//_timer.Stop();
					//_state = ButtonState.On;
					//_progress = 100;
				}
				this.Invalidate(); // force repaint
			};

			_state = ButtonState.Off;
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);
		}

		public ButtonState State
		{
			get => _state;
			set
			{
				_state = value;
				if (_state == ButtonState.Loading)
				{
					this.Text = "\r\n\r\n\r\nЗагрузка...";
					this.ForeColor = Color.FromArgb(63, 138, 255);
					if (_timer != null)
					{
						_timer.Start();
					}
					_progress = 0;
				}
				else if (_state == ButtonState.On)
				{
					this.Text = "\r\n\r\n\r\nВыключить";
					this.ForeColor = Color.White;
					if (_timer != null)
					{
						_timer.Stop();
					}
				}
				else if (_state == ButtonState.Off)
				{
					this.Text = "\r\n\r\n\r\nВключить";
					this.ForeColor = Color.FromArgb(63, 138, 255);
				}
				Invalidate();
			}
		}

		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);

			// Click logic to switch states
			if (State == ButtonState.Off)
			{
				// Start loading
				State = ButtonState.Loading;				
				_progress = 0;
				_timer.Start();
			}
			else if (State == ButtonState.On)
			{
				// Switch back to Off
				State = ButtonState.Off;
				_progress = 0;
				_timer.Stop();
			}

			Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{			

			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			// Calculate a square based on the shortest side
			int diameter = Math.Min(this.Width, this.Height);
			var rect = new Rectangle(0, 0, diameter , diameter);

			// Center the circle if control is not square
			// (simple way: draw at top-left, or compute offsets)
			int offsetX = (this.Width - diameter) / 2;
			int offsetY = (this.Height - diameter) / 2;
			rect.Offset(offsetX, offsetY);

			var rect1 = rect;
			rect1.Inflate(-border, -border);
			// Background circle color depends on state
			Color circleColor;
			//string text;

			switch (_state)
			{
				case ButtonState.Off:
					circleColor = Color.White;
					//text = "Включить";
					break;
				case ButtonState.Loading:
					circleColor = Color.White;
					//text = "Загрузка...";
					break;
				case ButtonState.On:
					circleColor = Color.FromArgb(63,138,255);
					//text = "Выключить";
					break;
				default:
					circleColor = Color.White;
					//text = string.Empty;
					break;
			}

			using (SolidBrush brush = new SolidBrush(circleColor))
			{
				e.Graphics.FillEllipse(brush, rect);
			}

			if(_state == ButtonState.Off || _state == ButtonState.On)
			{
				using (Pen pen = new Pen(Color.LightBlue, 2))
				{
					e.Graphics.DrawEllipse(pen, rect1);
				}
			}
			else
			{
				using (Pen pen = new Pen(Color.LightBlue, border))
				{
					e.Graphics.DrawEllipse(pen, rect1);
				}
			}
			// Draw the circular border
			

			// If Loading, draw progress arc
			if (_state == ButtonState.Loading)
			{
				// The progress arc is from -90 degrees (top) clockwise
				float sweepAngle = 360f * _progress / 100f;
				using (Pen progressPen = new Pen(Color.DodgerBlue, border))
				{
					e.Graphics.DrawArc(progressPen, rect1, -90, sweepAngle);
				}
			}
			/*
			// Draw button text in the center
			using (StringFormat sf = new StringFormat()
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center
			})
			using (SolidBrush textBrush = new SolidBrush(Color.Black))
			{
				e.Graphics.DrawString(text, this.Font, textBrush, rect, sf);
			}
			*/

			base.OnPaint(e);
		}
	}

}
