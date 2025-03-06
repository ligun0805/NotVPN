using NOTVPN.Screens;
using NOTVPN.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTVPN
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);			
			//(new Login()).Show();
			ConsoleHelper.EnsureConsole(hideWindow: true); // Set hideWindow to true if you do not want the console to be visible.

            (new Splash()).Show();
            //(new MainFrm()).Show();
            Application.Run();
		}
	}
}
