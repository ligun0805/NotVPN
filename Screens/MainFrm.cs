using NOTVPN.Template;
using NOTVPN.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NOTVPN.Utils.LibHelper;

namespace NOTVPN.Screens
{
	public partial class MainFrm : Form
	{
		public static IntPtr pDll ;
		private Stack<Control> _navigationStack = new Stack<Control>();

		public MainFrm()
		{
			InitializeComponent();

			// Pass reference to MainForm or use events
			ShowControl(new WorkScreen(this));
		}

		public void ShowControl(Control newControl, bool pushCurrent = true, bool prev = false , string prevTitle = "")
		{
			if (newControl is BaseScreenControl)
			{
				BaseScreenControl ctrl = (BaseScreenControl)newControl;
				ctrl.NavigationRequired += Setting_NavigationRequired;
			}
			
			btnPrev.Visible = prev;
			btnPrev.Text = prevTitle; 
			// If we already have something loaded, push that into stack
			if (pushCurrent)
			{
				_navigationStack.Push(newControl);
			}

			panelContainer.Controls.Clear();
			newControl.Dock = DockStyle.Fill;
			panelContainer.Controls.Add(newControl);
		}

		private void Setting_NavigationRequired(NavInfo obj)
		{
			if(obj.Action)
			{
				ShowControl(obj.Control, true,true, obj.Control.Title);
			}
			else
			{
				GoBack(null,null);
			}
		}

		// Allows going “back” to previous screen
		public void GoBack(object sender, EventArgs e)
		{
			if (_navigationStack.Count > 0)
			{
				_navigationStack.Pop();
				var previousControl = _navigationStack.ElementAt(0);
				if (previousControl is WorkScreen)
				{
				
					btnPrev.Visible=false;
				}
				else
				{
					btnPrev.Visible = true;
				}
				//var previousControl = _navigationStack.Pop();
				panelContainer.Controls.Clear();
				previousControl.Dock = DockStyle.Fill;
				panelContainer.Controls.Add(previousControl);
			}
		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			// Check if the user clicked Yes
			if (result == DialogResult.Yes)
			{
				// Exit the application
				if (MainFrm.pDll != IntPtr.Zero)
				{
					/*
					try
					{
						IntPtr pAddressOfFunctionToCall = LibHelper.GetProcAddress(pDll, "leaf_shutdown");

						LeafShutdownDelegate leafShutdown = (LeafShutdownDelegate)Marshal.GetDelegateForFunctionPointer(
						pAddressOfFunctionToCall, typeof(LeafShutdownDelegate));

						_ = leafShutdown(rt_id);
					}
					catch { 
					}
					*/
					
					LibHelper.FreeLibrary(MainFrm.pDll);
				}
				Application.Exit();
			}
		}
	}
}
