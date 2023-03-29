using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VentoyUI.Helpers;
internal class WinAPIHelper
{
    [DllImport("user32.dll", EntryPoint = "ShowWindow", CharSet = CharSet.Auto)]
    public static extern int ShowWindow(IntPtr hwnd, int nCmdShow);
    [DllImport("User32.dll")]
    public static extern IntPtr FindWindow(string lpClassName, string lpWindowTitle);
    [DllImport("User32.dll")]
    public static extern bool CloseWindow(IntPtr hwnd);
    [DllImport("User32.dll", EntryPoint = "SendMessageA")]
    public static extern IntPtr SendMessage(IntPtr hwnd, uint msg, IntPtr wparam, IntPtr lparam);
}
