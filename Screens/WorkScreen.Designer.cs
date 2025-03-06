namespace NOTVPN.Screens
{
	partial class WorkScreen
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
			this.lblStatus = new System.Windows.Forms.Label();
			this.btnQuit = new NOTVPN.Template.CustomButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnProcess = new NOTVPN.Template.CircularProgressButton();
			this.customButton7 = new NOTVPN.Template.CustomButton();
			this.customButton8 = new NOTVPN.Template.CustomButton();
			this.customButton6 = new NOTVPN.Template.CustomButton();
			this.customButton5 = new NOTVPN.Template.CustomButton();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.customButton4 = new NOTVPN.Template.CustomButton();
			this.sep3 = new NOTVPN.Template.Sep();
			this.customButton3 = new NOTVPN.Template.CustomButton();
			this.btnSetting = new NOTVPN.Template.CustomButton();
			this.label2 = new System.Windows.Forms.Label();
			this.sep2 = new NOTVPN.Template.Sep();
			this.tunnelChannel5 = new NOTVPN.Template.tunnelChannel();
			this.tunnelChannel4 = new NOTVPN.Template.tunnelChannel();
			this.tunnelChannel3 = new NOTVPN.Template.tunnelChannel();
			this.tunnelChannel2 = new NOTVPN.Template.tunnelChannel();
			this.tunnelChannel1 = new NOTVPN.Template.tunnelChannel();
			this.customButton1 = new NOTVPN.Template.CustomButton();
			this.label1 = new System.Windows.Forms.Label();
			this.sep1 = new NOTVPN.Template.Sep();
			this.rjTextBox1 = new NOTVPN.Template.RJTextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.Location = new System.Drawing.Point(222, 560);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(175, 23);
			this.lblStatus.TabIndex = 55;
			this.lblStatus.Text = "Status : Nothing";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnQuit
			// 
			this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnQuit.BackColor = System.Drawing.Color.Transparent;
			this.btnQuit.BGImage = global::NOTVPN.customRes.close;
			this.btnQuit.BGRoundColor = System.Drawing.Color.Transparent;
			this.btnQuit.BorderColor = System.Drawing.Color.Transparent;
			this.btnQuit.BorderThickness = 1;
			this.btnQuit.CornerRadius = 0;
			this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuit.Location = new System.Drawing.Point(915, 11);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(30, 30);
			this.btnQuit.TabIndex = 54;
			this.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BackgroundImage = global::NOTVPN.customRes.Vector;
			this.panel1.Controls.Add(this.btnProcess);
			this.panel1.Location = new System.Drawing.Point(15, 152);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(502, 269);
			this.panel1.TabIndex = 53;
			// 
			// btnProcess
			// 
			this.btnProcess.border = 20;
			this.btnProcess.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
			this.btnProcess.Icon = null;
			this.btnProcess.Image = global::NOTVPN.customRes.Power;
			this.btnProcess.Location = new System.Drawing.Point(143, 27);
			this.btnProcess.Name = "btnProcess";
			this.btnProcess.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
			this.btnProcess.Size = new System.Drawing.Size(200, 200);
			this.btnProcess.State = NOTVPN.Template.ButtonState.Off;
			this.btnProcess.TabIndex = 0;
			this.btnProcess.Text = "\r\n\r\n\r\nВключить";
			this.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnProcess.Click += new System.EventHandler(this.circularProgressButton1_Click);
			// 
			// customButton7
			// 
			this.customButton7.BackColor = System.Drawing.Color.Transparent;
			this.customButton7.BGImage = global::NOTVPN.customRes.Group_2085655866;
			this.customButton7.BGRoundColor = System.Drawing.Color.Transparent;
			this.customButton7.BorderColor = System.Drawing.Color.Transparent;
			this.customButton7.BorderThickness = 1;
			this.customButton7.CornerRadius = 0;
			this.customButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customButton7.Location = new System.Drawing.Point(30, 37);
			this.customButton7.Name = "customButton7";
			this.customButton7.Size = new System.Drawing.Size(15, 15);
			this.customButton7.TabIndex = 52;
			this.customButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// customButton8
			// 
			this.customButton8.BackColor = System.Drawing.Color.Transparent;
			this.customButton8.BGImage = global::NOTVPN.customRes.Group_2085655867;
			this.customButton8.BGRoundColor = System.Drawing.Color.Transparent;
			this.customButton8.BorderColor = System.Drawing.Color.Transparent;
			this.customButton8.BorderThickness = 1;
			this.customButton8.CornerRadius = 0;
			this.customButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customButton8.Location = new System.Drawing.Point(11, 37);
			this.customButton8.Name = "customButton8";
			this.customButton8.Size = new System.Drawing.Size(15, 15);
			this.customButton8.TabIndex = 51;
			this.customButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// customButton6
			// 
			this.customButton6.BackColor = System.Drawing.Color.Transparent;
			this.customButton6.BGImage = global::NOTVPN.customRes.Group_2085655864;
			this.customButton6.BGRoundColor = System.Drawing.Color.Transparent;
			this.customButton6.BorderColor = System.Drawing.Color.Transparent;
			this.customButton6.BorderThickness = 1;
			this.customButton6.CornerRadius = 0;
			this.customButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customButton6.Location = new System.Drawing.Point(30, 16);
			this.customButton6.Name = "customButton6";
			this.customButton6.Size = new System.Drawing.Size(15, 15);
			this.customButton6.TabIndex = 50;
			this.customButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// customButton5
			// 
			this.customButton5.BackColor = System.Drawing.Color.Transparent;
			this.customButton5.BGImage = global::NOTVPN.customRes.Group_2085655865;
			this.customButton5.BGRoundColor = System.Drawing.Color.Transparent;
			this.customButton5.BorderColor = System.Drawing.Color.Transparent;
			this.customButton5.BorderThickness = 1;
			this.customButton5.CornerRadius = 0;
			this.customButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customButton5.Location = new System.Drawing.Point(11, 16);
			this.customButton5.Name = "customButton5";
			this.customButton5.Size = new System.Drawing.Size(15, 15);
			this.customButton5.TabIndex = 49;
			this.customButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(58, 27);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(157, 17);
			this.label5.TabIndex = 47;
			this.label5.Text = "Частичное шифрование";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.label4.Location = new System.Drawing.Point(66, 574);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 17);
			this.label4.TabIndex = 44;
			this.label4.Text = "95.108.33.28";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::NOTVPN.customRes.Group_712;
			this.pictureBox2.Location = new System.Drawing.Point(478, 559);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(20, 22);
			this.pictureBox2.TabIndex = 43;
			this.pictureBox2.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(66, 553);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 20);
			this.label3.TabIndex = 42;
			this.label3.Text = "Автовыбор";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::NOTVPN.customRes.Germany;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.Location = new System.Drawing.Point(25, 564);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 24);
			this.pictureBox1.TabIndex = 41;
			this.pictureBox1.TabStop = false;
			// 
			// customButton4
			// 
			this.customButton4.BackColor = System.Drawing.Color.Transparent;
			this.customButton4.BGImage = global::NOTVPN.customRes.Question;
			this.customButton4.BGRoundColor = System.Drawing.Color.Transparent;
			this.customButton4.BorderColor = System.Drawing.Color.Transparent;
			this.customButton4.BorderThickness = 1;
			this.customButton4.CornerRadius = 0;
			this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customButton4.Location = new System.Drawing.Point(222, 27);
			this.customButton4.Name = "customButton4";
			this.customButton4.Size = new System.Drawing.Size(19, 19);
			this.customButton4.TabIndex = 48;
			this.customButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sep3
			// 
			this.sep3.lineColor = System.Drawing.Color.LightGray;
			this.sep3.lineWidth = 2;
			this.sep3.Location = new System.Drawing.Point(-2, 65);
			this.sep3.Name = "sep3";
			this.sep3.Size = new System.Drawing.Size(530, 10);
			this.sep3.style = NOTVPN.Template.SepStype.Horizental;
			this.sep3.TabIndex = 46;
			this.sep3.Text = "sep3";
			// 
			// customButton3
			// 
			this.customButton3.BackColor = System.Drawing.Color.Transparent;
			this.customButton3.BGImage = global::NOTVPN.customRes.SwitchOff;
			this.customButton3.BGRoundColor = System.Drawing.Color.Transparent;
			this.customButton3.BorderColor = System.Drawing.Color.Transparent;
			this.customButton3.BorderThickness = 1;
			this.customButton3.CornerRadius = 0;
			this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customButton3.Location = new System.Drawing.Point(441, 16);
			this.customButton3.Name = "customButton3";
			this.customButton3.Size = new System.Drawing.Size(57, 43);
			this.customButton3.TabIndex = 45;
			this.customButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnSetting
			// 
			this.btnSetting.BackColor = System.Drawing.Color.Transparent;
			this.btnSetting.BGImage = global::NOTVPN.customRes.Preferences;
			this.btnSetting.BGRoundColor = System.Drawing.Color.Transparent;
			this.btnSetting.BorderColor = System.Drawing.Color.Transparent;
			this.btnSetting.BorderThickness = 1;
			this.btnSetting.CornerRadius = 0;
			this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSetting.Location = new System.Drawing.Point(839, 560);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new System.Drawing.Size(24, 24);
			this.btnSetting.TabIndex = 40;
			this.btnSetting.Text = " ";
			this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(687, 564);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 17);
			this.label2.TabIndex = 39;
			this.label2.Text = "VolkovAR@gmail.com";
			// 
			// sep2
			// 
			this.sep2.lineColor = System.Drawing.Color.LightGray;
			this.sep2.lineWidth = 2;
			this.sep2.Location = new System.Drawing.Point(-2, 530);
			this.sep2.Name = "sep2";
			this.sep2.Size = new System.Drawing.Size(889, 10);
			this.sep2.style = NOTVPN.Template.SepStype.Horizental;
			this.sep2.TabIndex = 38;
			this.sep2.Text = "sep2";
			// 
			// tunnelChannel5
			// 
			this.tunnelChannel5.BackColor = System.Drawing.Color.Transparent;
			this.tunnelChannel5.Location = new System.Drawing.Point(579, 479);
			this.tunnelChannel5.Name = "tunnelChannel5";
			this.tunnelChannel5.Size = new System.Drawing.Size(272, 45);
			this.tunnelChannel5.TabIndex = 37;
			// 
			// tunnelChannel4
			// 
			this.tunnelChannel4.BackColor = System.Drawing.Color.Transparent;
			this.tunnelChannel4.Location = new System.Drawing.Point(579, 413);
			this.tunnelChannel4.Name = "tunnelChannel4";
			this.tunnelChannel4.Size = new System.Drawing.Size(272, 45);
			this.tunnelChannel4.TabIndex = 36;
			// 
			// tunnelChannel3
			// 
			this.tunnelChannel3.BackColor = System.Drawing.Color.Transparent;
			this.tunnelChannel3.Location = new System.Drawing.Point(578, 349);
			this.tunnelChannel3.Name = "tunnelChannel3";
			this.tunnelChannel3.Size = new System.Drawing.Size(272, 45);
			this.tunnelChannel3.TabIndex = 35;
			// 
			// tunnelChannel2
			// 
			this.tunnelChannel2.BackColor = System.Drawing.Color.Transparent;
			this.tunnelChannel2.Location = new System.Drawing.Point(578, 285);
			this.tunnelChannel2.Name = "tunnelChannel2";
			this.tunnelChannel2.Size = new System.Drawing.Size(272, 45);
			this.tunnelChannel2.TabIndex = 34;
			// 
			// tunnelChannel1
			// 
			this.tunnelChannel1.BackColor = System.Drawing.Color.Transparent;
			this.tunnelChannel1.Location = new System.Drawing.Point(578, 224);
			this.tunnelChannel1.Name = "tunnelChannel1";
			this.tunnelChannel1.Size = new System.Drawing.Size(272, 45);
			this.tunnelChannel1.TabIndex = 33;
			// 
			// customButton1
			// 
			this.customButton1.BackColor = System.Drawing.Color.Transparent;
			this.customButton1.BGImage = global::NOTVPN.customRes.Group_7;
			this.customButton1.BGRoundColor = System.Drawing.Color.Transparent;
			this.customButton1.BorderColor = System.Drawing.Color.Transparent;
			this.customButton1.BorderThickness = 1;
			this.customButton1.CornerRadius = 0;
			this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customButton1.Location = new System.Drawing.Point(826, 179);
			this.customButton1.Name = "customButton1";
			this.customButton1.Size = new System.Drawing.Size(24, 24);
			this.customButton1.TabIndex = 32;
			this.customButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(576, 179);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 17);
			this.label1.TabIndex = 31;
			this.label1.Text = "Самые быстрые локации";
			// 
			// sep1
			// 
			this.sep1.lineColor = System.Drawing.Color.LightGray;
			this.sep1.lineWidth = 2;
			this.sep1.Location = new System.Drawing.Point(523, 3);
			this.sep1.Name = "sep1";
			this.sep1.Size = new System.Drawing.Size(15, 603);
			this.sep1.style = NOTVPN.Template.SepStype.Vertical;
			this.sep1.TabIndex = 30;
			this.sep1.Text = "sep1";
			// 
			// rjTextBox1
			// 
			this.rjTextBox1.BackColor = System.Drawing.Color.White;
			this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
			this.rjTextBox1.BorderRadius = 10;
			this.rjTextBox1.BorderSize = 1;
			this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjTextBox1.Location = new System.Drawing.Point(560, 65);
			this.rjTextBox1.Multiline = false;
			this.rjTextBox1.Name = "rjTextBox1";
			this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
			this.rjTextBox1.PasswordChar = false;
			this.rjTextBox1.PlaceholderColor = System.Drawing.Color.Silver;
			this.rjTextBox1.PlaceholderText = "Поиск";
			this.rjTextBox1.Size = new System.Drawing.Size(319, 59);
			this.rjTextBox1.Stype = NOTVPN.Template.TextBoxStype.Search;
			this.rjTextBox1.TabIndex = 29;
			this.rjTextBox1.Texts = "";
			this.rjTextBox1.UnderlinedStyle = false;
			// 
			// WorkScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.customButton7);
			this.Controls.Add(this.customButton8);
			this.Controls.Add(this.customButton6);
			this.Controls.Add(this.customButton5);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.customButton4);
			this.Controls.Add(this.sep3);
			this.Controls.Add(this.customButton3);
			this.Controls.Add(this.btnSetting);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.sep2);
			this.Controls.Add(this.tunnelChannel5);
			this.Controls.Add(this.tunnelChannel4);
			this.Controls.Add(this.tunnelChannel3);
			this.Controls.Add(this.tunnelChannel2);
			this.Controls.Add(this.tunnelChannel1);
			this.Controls.Add(this.customButton1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.sep1);
			this.Controls.Add(this.rjTextBox1);
			this.Name = "WorkScreen";
			this.Size = new System.Drawing.Size(900, 600);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblStatus;
		private Template.CustomButton btnQuit;
		private System.Windows.Forms.Panel panel1;
		private Template.CircularProgressButton btnProcess;
		private Template.CustomButton customButton7;
		private Template.CustomButton customButton8;
		private Template.CustomButton customButton6;
		private Template.CustomButton customButton5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Template.CustomButton customButton4;
		private Template.Sep sep3;
		private Template.CustomButton customButton3;
		private Template.CustomButton btnSetting;
		private System.Windows.Forms.Label label2;
		private Template.Sep sep2;
		private Template.tunnelChannel tunnelChannel5;
		private Template.tunnelChannel tunnelChannel4;
		private Template.tunnelChannel tunnelChannel3;
		private Template.tunnelChannel tunnelChannel2;
		private Template.tunnelChannel tunnelChannel1;
		private Template.CustomButton customButton1;
		private System.Windows.Forms.Label label1;
		private Template.Sep sep1;
		private Template.RJTextBox rjTextBox1;
	}
}
