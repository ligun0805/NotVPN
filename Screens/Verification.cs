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
	public partial class Verification : Form
	{
		public Verification()
		{
			InitializeComponent();
		}

		private void Me_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Application.OpenForms.Count == 0)
			{
				Application.Exit();
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			AccountOk form = new AccountOk();
			form.Show();
			this.Close();
		}
	}
}
