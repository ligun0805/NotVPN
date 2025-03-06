namespace NOTVPN.Template
{
	partial class RoundedDigitTextBox
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._innerTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// _innerTextBox
			// 
			this._innerTextBox.AcceptsReturn = true;
			this._innerTextBox.AcceptsTab = true;
			this._innerTextBox.BackColor = System.Drawing.SystemColors.HotTrack;
			this._innerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._innerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._innerTextBox.ForeColor = System.Drawing.Color.White;
			this._innerTextBox.Location = new System.Drawing.Point(10, 10);
			this._innerTextBox.Margin = new System.Windows.Forms.Padding(6);
			this._innerTextBox.MaxLength = 1;
			this._innerTextBox.Name = "_innerTextBox";
			this._innerTextBox.Size = new System.Drawing.Size(50, 46);
			this._innerTextBox.TabIndex = 0;
			this._innerTextBox.Text = "7";
			this._innerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// RoundedDigitTextBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.HotTrack;
			this.Controls.Add(this._innerTextBox);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "RoundedDigitTextBox";
			this.Size = new System.Drawing.Size(70, 66);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _innerTextBox;
	}
}
