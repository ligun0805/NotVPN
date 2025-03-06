namespace NOTVPN.Screens
{
	partial class Login
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rjTextBox1 = new NOTVPN.Template.RJTextBox();
			this.btnLogin = new NOTVPN.Template.CustomButton();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(105, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(707, 37);
			this.label2.TabIndex = 10;
			this.label2.Text = "Авторизация";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label3.Location = new System.Drawing.Point(67, 173);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(745, 37);
			this.label3.TabIndex = 11;
			this.label3.Text = "Введите вашу электронную почту";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rjTextBox1
			// 
			this.rjTextBox1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.rjTextBox1.BorderColor = System.Drawing.SystemColors.HotTrack;
			this.rjTextBox1.BorderFocusColor = System.Drawing.SystemColors.HotTrack;
			this.rjTextBox1.BorderRadius = 10;
			this.rjTextBox1.BorderSize = 1;
			this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjTextBox1.Location = new System.Drawing.Point(240, 249);
			this.rjTextBox1.Multiline = false;
			this.rjTextBox1.Name = "rjTextBox1";
			this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
			this.rjTextBox1.PasswordChar = false;
			this.rjTextBox1.PlaceholderColor = System.Drawing.Color.White;
			this.rjTextBox1.PlaceholderText = "Введите вашу почту";
			this.rjTextBox1.Size = new System.Drawing.Size(405, 63);
			this.rjTextBox1.TabIndex = 13;
			this.rjTextBox1.Texts = "";
			this.rjTextBox1.UnderlinedStyle = false;
			this.rjTextBox1.Click += new System.EventHandler(this.rjTextBox1_Click);
			this.rjTextBox1.Enter += new System.EventHandler(this.rjTextBox1_Enter);
			this.rjTextBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rjTextBox1_MouseClick);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.Transparent;
			this.btnLogin.BGImage = null;
			this.btnLogin.BGRoundColor = System.Drawing.Color.White;
			this.btnLogin.BorderColor = System.Drawing.Color.White;
			this.btnLogin.BorderThickness = 1;
			this.btnLogin.CornerRadius = 15;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnLogin.Location = new System.Drawing.Point(240, 352);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(405, 61);
			this.btnLogin.TabIndex = 8;
			this.btnLogin.Text = "Авторизация";
			this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::NOTVPN.customRes.back_bg;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(884, 561);
			this.Controls.Add(this.rjTextBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnLogin);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CustomTextBox Enabled";
			this.TopMost = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Me_FormClosed);
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private Template.CustomButton btnLogin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Template.RJTextBox rjTextBox1;
	}
}