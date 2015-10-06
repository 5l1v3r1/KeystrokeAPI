﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KeyloggerAPI
{
	/// <summary>
	/// Class to wrap the dependencies for the User32.dll
	/// </summary>
	internal static class User32
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern IntPtr SetWindowsHookEx(int idHook, LowLevelHook lpfn, IntPtr hMod, uint dwThreadId);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool UnhookWindowsHookEx(IntPtr hhk);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern IntPtr GetModuleHandle(string lpModuleName);

		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		internal static extern short GetKeyState(KeyValue virtualKeyCode);

		[DllImport("User32.dll")]
		internal static extern short GetAsyncKeyState(KeyValue vKey);

		[DllImport("User32.dll")]
		internal static extern int GetWindowText(int hwnd, StringBuilder s, int nMaxCount);

		[DllImport("User32.dll")]
		internal static extern int GetForegroundWindow();

		internal delegate IntPtr LowLevelHook(int nCode, IntPtr wParam, IntPtr lParam);
	}
}
