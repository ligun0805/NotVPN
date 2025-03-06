using NOTVPN.Template;
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
	public partial class AdvancedSetting : BaseScreenControl
	{
		public AdvancedSetting()
		{
			InitializeComponent();
		}

		private void AdvancedSetting_Load(object sender, EventArgs e)
		{
			panVPNDetails.Visible = false; panDNSDetails.Visible = false;panTunnelDetails.Visible = false;
			bodyPan.Width = this.Width;
		}

		private void btnVPN_Click(object sender, EventArgs e)
		{
			panVPNDetails.Visible = true; panDNSDetails.Visible = false; panTunnelDetails.Visible = false;
			bodyPan.Width = 530;
		}

		private void btnDNS_Click(object sender, EventArgs e)
		{
			panVPNDetails.Visible = false; panDNSDetails.Visible = true; panTunnelDetails.Visible = false;
			bodyPan.Width = 530;
		}

		private void btnTunnel_Click(object sender, EventArgs e)
		{
			panVPNDetails.Visible = false; panDNSDetails.Visible = false; panTunnelDetails.Visible = true;
			bodyPan.Width = 530;
		}
	}
}
