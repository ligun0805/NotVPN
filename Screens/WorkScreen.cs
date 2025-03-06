using NOTVPN.Template;
using NOTVPN.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NOTVPN.Utils.LibHelper;

namespace NOTVPN.Screens
{	
	public partial class WorkScreen : BaseScreenControl
	{
		private MainFrm _parentForm;
		private StdOutRedirector _redirector;

		public WorkScreen(MainFrm parent)
		{
			InitializeComponent();

			_redirector = new StdOutRedirector();
			_redirector.OnVPNStatus_Changed += VPNStatus_Changed;

			// Redirect stdout before launching leaf/wintun operations.
			_redirector.RedirectStdOut();
			_parentForm = parent;
		}

		private void VPNStatus_Changed(VPNStatus status)
		{
			if (InvokeRequired)
			{
				Invoke(new Action<VPNStatus>(VPNStatus_Changed), status);
				return;
			}
			switch (status)
			{
				case VPNStatus.Starting:
					lblStatus.Text = "Starting...";
					break;
				case VPNStatus.Creating_Adapter:
					lblStatus.Text = "Creating Adapter...";
					break;
				case VPNStatus.Start_Tunnel:
					lblStatus.Text = "Running";
					btnProcess.State = Template.ButtonState.On;
					break;
				default:
					break;
			}

		}

		private void perFormLeaf()
		{
			MainFrm.pDll = LibHelper.LoadLibrary(dllPath);
			if (MainFrm.pDll == IntPtr.Zero)
			{
				int errorCode = Marshal.GetLastWin32Error();
				string errorMessage = GetErrorMessage(errorCode);
				MessageBox.Show("Failed to load DLL. Error: " + errorMessage);
				return;
			}
			try
			{
				// Get pointer to the function
				IntPtr pAddressOfFunctionToCall = LibHelper.GetProcAddress(MainFrm.pDll, "leaf_run");
				if (pAddressOfFunctionToCall == IntPtr.Zero)
				{
					MessageBox.Show("Failed to get the function address");
					return;
				}

				LeafRunDelegate leafRun = (LeafRunDelegate)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(LeafRunDelegate));

				//leafRunWithOptionDelegate leafRun = (leafRunWithOptionDelegate)Marshal.GetDelegateForFunctionPointer(
				//	pAddressOfFunctionToCall, typeof(leafRunWithOptionDelegate));

				int result = leafRun(rt_id, configPath);

				// Handle result
				MessageBox.Show("Result from DLL function: " + result);
			}
			catch
			{
				if (MainFrm.pDll != IntPtr.Zero)
				{
					IntPtr pAddressOfFunctionToCall = LibHelper.GetProcAddress(MainFrm.pDll, "leaf_shutdown");

					LeafShutdownDelegate leafShutdown = (LeafShutdownDelegate)Marshal.GetDelegateForFunctionPointer(
					pAddressOfFunctionToCall, typeof(LeafRunDelegate));

					Boolean result = leafShutdown(rt_id);
					LibHelper.FreeLibrary(MainFrm.pDll);
				}
			}
		}

		private void circularProgressButton1_Click(object sender, EventArgs e)
		{
			if (btnProcess.State == Template.ButtonState.Off)
			{
				Task.Run(() => perFormLeaf());
			}
		}

		private void btnSetting_Click(object sender, EventArgs e)
		{
			Setting setting = new Setting();
			setting.Title = "Настройки";
			NavInfo navInfo = new NavInfo(true,setting);
			RaiseNavigationRequired(navInfo);
		}
	}
}
