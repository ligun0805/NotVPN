namespace NOTVPN.Template
{
	partial class RJTextBox
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblPlaceholder = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.AcceptsReturn = true;
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.CausesValidation = false;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(46, 20);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(303, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.TabStop = false;
			this.textBox1.Text = "jinjackey1121@gmail.com";
			this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
			this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
			this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::NOTVPN.customRes.Envelope;
			this.pictureBox1.Location = new System.Drawing.Point(14, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(26, 30);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// lblPlaceholder
			// 
			this.lblPlaceholder.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.lblPlaceholder.AutoSize = true;
			this.lblPlaceholder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblPlaceholder.ForeColor = System.Drawing.Color.White;
			this.lblPlaceholder.Location = new System.Drawing.Point(46, 47);
			this.lblPlaceholder.Name = "lblPlaceholder";
			this.lblPlaceholder.Size = new System.Drawing.Size(103, 22);
			this.lblPlaceholder.TabIndex = 2;
			this.lblPlaceholder.Text = "placeholder";
			this.lblPlaceholder.Click += new System.EventHandler(this.lblPlaceholder_Click);
			this.lblPlaceholder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblPlaceholder_MouseClick);
			// 
			// RJTextBox
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.HotTrack;
			this.Controls.Add(this.lblPlaceholder);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "RJTextBox";
			this.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
			this.Size = new System.Drawing.Size(359, 82);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblPlaceholder;
	}
}
