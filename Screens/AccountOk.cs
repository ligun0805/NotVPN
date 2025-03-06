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
	public partial class AccountOk : Form
	{
		public AccountOk()
		{
			InitializeComponent();
			delayTimer.Start();
		}

		private void Me_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Application.OpenForms.Count == 0)
			{
				Application.Exit();
			}
		}

		private void delayTimer_Tick(object sender, EventArgs e)
		{			
			delayTimer.Stop();
			(new MainFrm()).Show();
			this.Close();
		}
	}
}
