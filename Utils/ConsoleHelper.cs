using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NOTVPN.Utils
{
	public static class ConsoleHelper
	{
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool AllocConsole();

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool FreeConsole();

		[DllImport("kernel32.dll")]
		private static extern IntPtr GetConsoleWindow();

		[DllImport("user32.dll")]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		private const int SW_HIDE = 0;

		/// <summary>
		/// Ensures that a console is available. Optionally, you can hide the console window.
		/// </summary>
		public static void EnsureConsole(bool hideWindow = false)
		{
			if (GetConsoleWindow() == IntPtr.Zero)
			{
				AllocConsole();
			}

			if (hideWindow)
			{
				var handle = GetConsoleWindow();
				if (handle != IntPtr.Zero)
				{
					ShowWindow(handle, SW_HIDE);
				}
			}
		}
	}
}
