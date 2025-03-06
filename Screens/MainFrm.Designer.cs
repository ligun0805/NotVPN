namespace NOTVPN.Screens
{
	partial class MainFrm
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
			this.panelContainer = new System.Windows.Forms.Panel();
			this.btnPrev = new System.Windows.Forms.Button();
			this.btnQuit = new NOTVPN.Template.CustomButton();
			this.SuspendLayout();
			// 
			// panelContainer
			// 
			this.panelContainer.BackColor = System.Drawing.Color.Transparent;
			this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContainer.Location = new System.Drawing.Point(20, 20);
			this.panelContainer.Name = "panelContainer";
			this.panelContainer.Size = new System.Drawing.Size(900, 600);
			this.panelContainer.TabIndex = 28;
			// 
			// btnPrev
			// 
			this.btnPrev.BackColor = System.Drawing.Color.Transparent;
			this.btnPrev.FlatAppearance.BorderSize = 0;
			this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrev.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrev.Image = global::NOTVPN.customRes.Chevron_left;
			this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPrev.Location = new System.Drawing.Point(37, 14);
			this.btnPrev.Margin = new System.Windows.Forms.Padding(0);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.Size = new System.Drawing.Size(308, 35);
			this.btnPrev.TabIndex = 29;
			this.btnPrev.Text = "Настройки";
			this.btnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrev.UseVisualStyleBackColor = false;
			this.btnPrev.Visible = false;
			this.btnPrev.Click += new System.EventHandler(this.GoBack);
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
			this.btnQuit.Location = new System.Drawing.Point(903, 7);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(30, 30);
			this.btnQuit.TabIndex = 27;
			this.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
			// 
			// MainFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(940, 640);
			this.Controls.Add(this.btnPrev);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.panelContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainFrm";
			this.Padding = new System.Windows.Forms.Padding(20);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainFrm";
			this.ResumeLayout(false);

		}

		#endregion
		private Template.CustomButton btnQuit;
		private System.Windows.Forms.Panel panelContainer;
		private System.Windows.Forms.Button btnPrev;
	}
}