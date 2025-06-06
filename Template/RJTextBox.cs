﻿using NOTVPN.Utils;
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

namespace NOTVPN.Template
{
	public enum TextBoxStype
	{
		Search =0,
		Mail
	}
	[DefaultEvent("_TextChanged")]
	public partial class RJTextBox : UserControl
	{
		#region -> Fields
		//Fields
		private Color borderColor = Color.MediumSlateBlue;
		private Color borderFocusColor = Color.HotPink;
		private int borderSize = 1;
		private bool underlinedStyle = false;
		private bool isFocused = false;

		private int borderRadius = 0;
		private Color placeholderColor = Color.DarkGray;
		private string placeholderText = "";
		private bool isPlaceholder = false;
		private bool isPasswordChar = false;
		private TextBoxStype _style;

				//Events
		public event EventHandler _TextChanged;

		#endregion

		public RJTextBox()
		{
			InitializeComponent();
			Stype = TextBoxStype.Mail;
			lblPlaceholder.Location = textBox1.Location;
			lblPlaceholder.SendToBack();
		}

		#region -> Properties
		[Category("RJ Code Advance")]
		public Color BorderColor
		{
			get { return borderColor; }
			set
			{
				borderColor = value;
				this.Invalidate();
			}
		}
		[Category("RJ Code Advance")]
		public TextBoxStype Stype
		{
			get { return _style; }
			set
			{
				_style = value;
				if (value == TextBoxStype.Mail)
				{
					pictureBox1.Image = global::NOTVPN.customRes.Envelope;
				}
				else if (value == TextBoxStype.Search)
				{
					pictureBox1.Image = global::NOTVPN.customRes.MagnifyingGlassPlus1;
				}
			}
		}

		[Category("RJ Code Advance")]
		public Color BorderFocusColor
		{
			get { return borderFocusColor; }
			set { borderFocusColor = value; }
		}

		[Category("RJ Code Advance")]
		public int BorderSize
		{
			get { return borderSize; }
			set
			{
				if (value >= 1)
				{
					borderSize = value;
					this.Invalidate();
				}
			}
		}

		[Category("RJ Code Advance")]
		public bool UnderlinedStyle
		{
			get { return underlinedStyle; }
			set
			{
				underlinedStyle = value;
				this.Invalidate();
			}
		}

		[Category("RJ Code Advance")]
		public bool PasswordChar
		{
			get { return isPasswordChar; }
			set
			{
				isPasswordChar = value;
				if (!isPlaceholder)
					textBox1.UseSystemPasswordChar = value;
			}
		}

		[Category("RJ Code Advance")]
		public bool Multiline
		{
			get { return textBox1.Multiline; }
			set { textBox1.Multiline = value; }
		}

		[Category("RJ Code Advance")]
		public override Color BackColor
		{
			get { return base.BackColor; }
			set
			{
				base.BackColor = value;
				textBox1.BackColor = value;
			}
		}

		[Category("RJ Code Advance")]
		public override Color ForeColor
		{
			get { return base.ForeColor; }
			set
			{
				base.ForeColor = value;
				textBox1.ForeColor = value;
			}
		}

		[Category("RJ Code Advance")]
		public override Font Font
		{
			get { return base.Font; }
			set
			{
				base.Font = value;
				textBox1.Font = value;
				if (this.DesignMode)
					UpdateControlHeight();
			}
		}

		[Category("RJ Code Advance")]
		public string Texts
		{
			get
			{
				if (isPlaceholder) return "";
				else return textBox1.Text;
			}
			set
			{
				textBox1.Text = value;
				SetPlaceholder();
			}
		}

		[Category("RJ Code Advance")]
		public int BorderRadius
		{
			get { return borderRadius; }
			set
			{
				if (value >= 0)
				{
					borderRadius = value;
					this.Invalidate();//Redraw control
				}
			}
		}

		[Category("RJ Code Advance")]
		public Color PlaceholderColor
		{
			get { return placeholderColor; }
			set
			{
				placeholderColor = value;
				if (isPlaceholder)
					textBox1.ForeColor = value;
			}
		}

		[Category("RJ Code Advance")]
		public string PlaceholderText
		{
			get { return placeholderText; }
			set
			{
				placeholderText = value;
				textBox1.Text = "";
				SetPlaceholder();
			}
		}



		#endregion

		#region -> Overridden methods
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (this.DesignMode)
				UpdateControlHeight();
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			UpdateControlHeight();
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graph = e.Graphics;

			if (borderRadius > 1)//Rounded TextBox
			{
				//-Fields
				var rectBorderSmooth = this.ClientRectangle;
				var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
				int smoothSize = borderSize > 0 ? borderSize : 1;

				using (GraphicsPath pathBorderSmooth = UIHelper.GetRoundedRectangle(rectBorderSmooth, borderRadius))
				using (GraphicsPath pathBorder = UIHelper.GetRoundedRectangle(rectBorder, borderRadius))
				using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
				using (Pen penBorder = new Pen(borderColor, borderSize))
				{
					//-Drawing
					this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
					if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
					graph.SmoothingMode = SmoothingMode.AntiAlias;
					penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
					if (isFocused) penBorder.Color = borderFocusColor;

					if (underlinedStyle) //Line Style
					{
						//Draw border smoothing
						graph.DrawPath(penBorderSmooth, pathBorderSmooth);
						//Draw border
						graph.SmoothingMode = SmoothingMode.None;
						graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
					}
					else //Normal Style
					{
						//Draw border smoothing
						//graph.DrawPath(penBorderSmooth, pathBorderSmooth);
						//Draw border
						graph.DrawPath(penBorder, pathBorder);
					}
				}
			}
			else //Square/Normal TextBox
			{
				//Draw border
				using (Pen penBorder = new Pen(borderColor, borderSize))
				{
					this.Region = new Region(this.ClientRectangle);
					penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
					if (isFocused) penBorder.Color = borderFocusColor;

					if (underlinedStyle) //Line Style
						graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
					else //Normal Style
						graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
				}
			}
		}
		#endregion

		#region -> Private methods
		public void SetPlaceholder()
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
			{
				isPlaceholder = true;
				lblPlaceholder.Text = placeholderText;
				lblPlaceholder.ForeColor = placeholderColor;
				//if (isPasswordChar)
				//	textBox1.UseSystemPasswordChar = false;
				lblPlaceholder.BringToFront();
			}
		}
		private void RemovePlaceholder()
		{
			if (isPlaceholder && placeholderText != "")
			{
				isPlaceholder = false;
				lblPlaceholder.Text = "";
				lblPlaceholder.ForeColor = this.ForeColor;
				lblPlaceholder.SendToBack();
				if (isPasswordChar)
					textBox1.UseSystemPasswordChar = true;
			}
		}

		private void SetTextBoxRoundedRegion()
		{
			GraphicsPath pathTxt;
			if (Multiline)
			{
				pathTxt = UIHelper.GetRoundedRectangle(textBox1.ClientRectangle, borderRadius - borderSize);
				textBox1.Region = new Region(pathTxt);
			}
			else
			{
				pathTxt = UIHelper.GetRoundedRectangle(textBox1.ClientRectangle, borderSize * 2);
				textBox1.Region = new Region(pathTxt);
			}
			pathTxt.Dispose();
		}
		private void UpdateControlHeight()
		{
			if (textBox1.Multiline == false)
			{
				int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
				textBox1.Multiline = true;
				textBox1.MinimumSize = new Size(0, txtHeight);
				textBox1.Multiline = false;

				this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
			}
		}
		#endregion

		public void setFocused()
		{
			RemovePlaceholder();
			textBox1?.Focus();
		}

		private void textBox1_Click(object sender, EventArgs e)
		{
			this.OnClick(e);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (_TextChanged != null)
				_TextChanged.Invoke(sender, e);

		}

		private void textBox1_Enter(object sender, EventArgs e)
		{
			isFocused = true;
			this.Invalidate();
			RemovePlaceholder();
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.OnKeyPress(e);
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			this.OnMouseLeave(e);
			
		}

		private void textBox1_MouseEnter(object sender, EventArgs e)
		{
			this.OnMouseEnter(e);
		}

		private void textBox1_MouseLeave(object sender, EventArgs e)
		{
			isFocused = false;
			this.Invalidate();
			SetPlaceholder();
		}

		private void lblPlaceholder_Click(object sender, EventArgs e)
		{
			setFocused();
		}

		private void lblPlaceholder_MouseClick(object sender, MouseEventArgs e)
		{
			setFocused();
		}
	}
}
