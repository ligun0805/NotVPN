using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTVPN.Template
{
	public struct NavInfo
	{
		public bool Action { get; }
		public BaseScreenControl Control { get; }

		public NavInfo(bool action, BaseScreenControl control)
		{
			Action = action;
			Control = control;
		}
	}

	public class BaseScreenControl : UserControl
	{

		public event Action<NavInfo> NavigationRequired;
		public string Title { get; set; }
		protected void RaiseNavigationRequired(NavInfo info)
		{
			NavigationRequired?.Invoke(info);
		}
	}
}
