using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NOTVPN.Utils
{
	public enum retCode
	{
		ERR_OK =0,
		ERR_CONFIG_PATH,
		ERR_CONFIG,
		ERR_IO,
		ERR_WATCHER,
		ERR_ASYNC_CHANNEL_SEND,
		ERR_SYNC_CHANNEL_RECV,
		ERR_RUNTIME_MANAGER,
		ERR_NO_CONFIG_FILE
	}
	public static class LibHelper
	{
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr LoadLibrary(string dllToLoad);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FreeLibrary(IntPtr hModule);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int LeafRunDelegate(ushort rt_id, string config_path);
		public delegate Boolean LeafShutdownDelegate(ushort rt_id);
		public delegate int leafRunWithOptionDelegate(ushort rt_id, string config_path, Boolean auto_reload, Boolean multi_thread, Boolean auto_threads, int threads, int stack_size);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern int FormatMessage(
			uint dwFlags,
			IntPtr lpSource,
			uint dwMessageId,
			uint dwLanguageId,
			StringBuilder lpBuffer,
			int nSize,
			IntPtr Arguments);

		public const uint FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x00000100;
		public const uint FORMAT_MESSAGE_IGNORE_INSERTS = 0x00000200;
		public const uint FORMAT_MESSAGE_FROM_SYSTEM = 0x00001000;
		public static string GetErrorMessage(int errorCode)
		{
			const int bufferSize = 512;
			StringBuilder messageBuffer = new StringBuilder(bufferSize);

			FormatMessage(
				FORMAT_MESSAGE_FROM_SYSTEM | FORMAT_MESSAGE_IGNORE_INSERTS,
				IntPtr.Zero,
				(uint)errorCode,
				0,
				messageBuffer,
				bufferSize,
				IntPtr.Zero);

			return messageBuffer.ToString().Trim();
		}

		public static string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libs", "leaf.dll");
		public static string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libs", "leaf.json");

		public static ushort rt_id = 1;
	}
}
