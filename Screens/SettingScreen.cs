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
	public partial class Setting : BaseScreenControl
	{
		public Setting()
		{
			InitializeComponent();
		}

		private void Setting_Load(object sender, EventArgs e)
		{
			panUserDetails.Visible = false;panLanguage.Visible = false;
			mainPanel.Width = this.Width;
		}

		private void btnAccountDetails_Click(object sender, EventArgs e)
		{
			panLanguage.Visible = false;
			panUserDetails.Visible = true;
			mainPanel.Width = 560;
		}

		private void btnRateDetails_Click(object sender, EventArgs e)
		{
			mainPanel.Width = 560;
		}

		private void btnAdvancedDetails_Click(object sender, EventArgs e)
		{
			mainPanel.Width = this.Width;

			AdvancedSetting setting = new AdvancedSetting();
			setting.Title = "Расширенные настройки";
			NavInfo navInfo = new NavInfo(true, setting);
			RaiseNavigationRequired(navInfo);
		}

		private void btnLangDetails_Click(object sender, EventArgs e)
		{
			panLanguage.Visible = true;
			panUserDetails.Visible = false;
			mainPanel.Width = 560;
		}

		private void btnQuestionDetails_Click(object sender, EventArgs e)
		{
			mainPanel.Width = 560;
		}
	}
}
