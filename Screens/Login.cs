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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
			btnLogin.ForeColor = Color.FromArgb(63, 138, 255);

		}

		private void Me_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Application.OpenForms.Count == 0)
			{
				Application.Exit();
			}
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}

		private void rjTextBox1_Enter(object sender, EventArgs e)
		{
			rjTextBox1.setFocused();
		}

		private void rjTextBox1_Click(object sender, EventArgs e)
		{
			rjTextBox1.setFocused();
		}

		private void rjTextBox1_MouseClick(object sender, MouseEventArgs e)
		{
			rjTextBox1.setFocused();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Verification frm = new Verification();
			frm.Show();
			this.Close();
			//MainFrm mainForm = new MainFrm();
			//mainForm.Show();
			//this.Close();
		}


	}
}
