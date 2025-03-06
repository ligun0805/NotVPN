using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTVPN.Template
{
	public enum VPNStatus
	{
		None = 0,
		Pending,
		Starting,
		Creating_Adapter,
		Start_Tunnel
	}
	public class StdOutRedirector
	{
		private string patten0 = "set OUTBOUND_INTERFACE";
		private string patten1 = "Creating adapter";
		private string patten2 = "start tun inbound";

		[DllImport("kernel32.dll", SetLastError = true)]
		static extern bool CreatePipe(out IntPtr hReadPipe, out IntPtr hWritePipe, IntPtr lpPipeAttributes, uint nSize);

		[DllImport("kernel32.dll", SetLastError = true)]
		static extern bool SetStdHandle(int nStdHandle, IntPtr hHandle);

		const int STD_OUTPUT_HANDLE = -11;

		private Thread _readThread;
		private StreamReader _reader;
		private StreamWriter _logWriter;
		// This event can be subscribed to by your UI code
		//public event Action<string> OnLogLineReceived;
		public event Action<VPNStatus> OnVPNStatus_Changed;

		public StdOutRedirector(string logFilePath = "leaflog.txt")
		{
			// Open the log file for appending; allow other processes to read the file.
			_logWriter = new StreamWriter(new FileStream(logFilePath, FileMode.Append, FileAccess.Write, FileShare.Read))
			{
				AutoFlush = true
			};
		}

		public void RedirectStdOut()
		{
			if (!CreatePipe(out IntPtr hReadPipe, out IntPtr hWritePipe, IntPtr.Zero, 0))
			{
				throw new Exception("Unable to create pipe for stdout redirection.");
			}

			// Set the standard output handle to our pipe's write handle
			if (!SetStdHandle(STD_OUTPUT_HANDLE, hWritePipe))
			{
				throw new Exception("Unable to redirect stdout.");
			}

			// Create a FileStream to read from the pipe handle
			var fs = new FileStream(new Microsoft.Win32.SafeHandles.SafeFileHandle(hReadPipe, ownsHandle: true), FileAccess.Read);
			_reader = new StreamReader(fs, Encoding.UTF8);

			// Start a thread to continuously read from the pipe
			_readThread = new Thread(ReadLoop) { IsBackground = true };
			_readThread.Start();
		}

		private void ReadLoop()
		{
			try
			{
				while (true)
				{
					string line = _reader.ReadLine();
					if (line != null)
					{
						ParseContent(line);
					}
					else
					{
						Thread.Sleep(10);
					}
				}
			}
			catch (Exception ex)
			{
				// Handle exceptions if needed (for example, log them)
				Console.Error.WriteLine(ex);
			}
		}
		private void ParseContent(string content)
		{
			_logWriter.WriteLine(content + Environment.NewLine);
			if (Regex.IsMatch(content, patten0))
			{
				OnVPNStatus_Changed?.Invoke(VPNStatus.Starting);
				return;
			}

			if (Regex.IsMatch(content, patten1))
			{
				OnVPNStatus_Changed?.Invoke(VPNStatus.Creating_Adapter);
				return;
			}
			if (Regex.IsMatch(content, patten2))
			{
				OnVPNStatus_Changed?.Invoke(VPNStatus.Start_Tunnel);
				_logWriter.Close();
				return;
			}
			OnVPNStatus_Changed?.Invoke(VPNStatus.Pending);
		}

		public void Dispose()
		{
			_logWriter?.Dispose();
			_reader?.Dispose();
			// Optionally, signal the thread to exit or join it.
		}
	}
}
