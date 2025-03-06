using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTVPN.Screens
{
	public partial class Account : Form
	{
		public Account()
		{
			InitializeComponent();
		}

		private void Account_Load(object sender, EventArgs e)
		{
			Font fnt = btnLogin.Font;
			btnLogin.ForeColor = Color.FromArgb(63,138,255);
		}

		private void Me_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Application.OpenForms.Count == 0)
			{
				Application.Exit();
			}
		}

		private void btnLogin_Clicked(object sender, EventArgs e)
		{
			Login loginForm = new Login();
			loginForm.Show();
			this.Close();
		}
	}
}
