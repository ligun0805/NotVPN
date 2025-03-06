using NOTVPN.Screens;
using NOTVPN.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTVPN
{
	public partial class Splash : Form
	{
		private int counter = 0;
		public Splash()
		{
			InitializeComponent();							

			this.DoubleBuffered = true; // Reduce flickering
			UIHelper.MakePanelAsGesture(this.panel1);

			progressBar.ProgressColor = Color.White; // Main Progress Color
			progressBar.AlternativeProgressColor = Color.FromArgb(85, 152, 255); // Alternate Stripes Color
			progressBar.ProgressContainerColor = Color.FromArgb(85, 152, 255); // Background Color
			progressBar.BorderColor  = Color.FromArgb(85, 152, 255); // Border Color
			progressBar.ShadowColor = Color.White; 
		}

		private void countTimer_Tick(object sender, EventArgs e)
		{
			counter++;
			lblCounter.Text = $"{counter}%";
			// Check if the counter has reached 100 (10 seconds)
			if (counter >= 100)
			{
				countTimer.Stop();

				// Show the login form
				Account accountForm = new Account();
				accountForm.Show();
				this.Close();
			}
			else
			{
				progressBar.Value = counter;
			}

			// Stop the timer and close the splash screen
			
		}

		private void Splash_Load(object sender, EventArgs e)
		{
			countTimer.Start();
		}

		private void Me_FormClosed(object sender, FormClosedEventArgs e)
		{
			if(Application.OpenForms.Count == 0)
			{
				Application.Exit();
			}
		}
	}
}
