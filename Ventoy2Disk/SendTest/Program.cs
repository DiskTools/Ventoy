using System.Runtime.InteropServices;

namespace SendTest;

internal class Program
{
    public static IntPtr zero = IntPtr.Zero;
    [DllImport("User32.dll")]
    static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wapram, IntPtr lparam);
    [DllImport("User32.dll")]
    static extern IntPtr FindWindow(string lpwindowclass, string lpwindowtile);
    [DllImport("User32.dll")]
    static extern int ShowWindow(IntPtr hwnd, int show);
    [DllImport("kernel32.dll")]
    static extern int GetLastError();
    static void Main(string[] args)
    {
        IntPtr hwnd = FindWindow("VENTOY","114514");
        Thread.Sleep(600);
        /*
        ShowWindow(hwnd, 0);
        if (hwnd == IntPtr.Zero)
            Console.WriteLine("Error!");*/
        SendMessage(hwnd, 0x400+1, zero, zero);
        Console.WriteLine(GetLastError());
        Console.WriteLine("Hello, World!");
    }
}
