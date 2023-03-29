using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using VentoyUI.Helpers;
using VentoyUI.ViewModels;
using Windows.UI.Popups;

namespace VentoyUI.Views;

public sealed partial class MainPage : Page
{
    [DllImport("User32.dll")]
    static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wapram, IntPtr lparam);
    [DllImport("User32.dll")]
    static extern IntPtr FindWindow(string lpwindowclass, string lpwindowtile);
    [DllImport("User32.dll")]
    static extern int ShowWindow(IntPtr hwnd, int show);
    public ShellViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<ShellViewModel>();
        InitializeComponent();
        Pages.Navigate(typeof(StartPage));
    }

    private void Setting_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        
    }

    private void StartInstall_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        //Process.Start("Ventoy_X64.exe");
        var hwnd = FindWindow("VENTOY","114514");
        int value = SendMessage(hwnd, 0x402, (IntPtr)MakeMessageHelper.MakeWParam(0,0x403), IntPtr.Zero).ToInt32();
        MessageDialog md = new MessageDialog(value.ToString(), "Test");
        md.ShowAsync();
        App.Global.UpgradeOrInstall = " /I";
        System.Diagnostics.Process p = new Process();
        p.StartInfo.UseShellExecute = true;
        p.StartInfo.FileName = "D:\\VentoyDebug\\Ventoy2Disk.exe";
        p.StartInfo.Arguments = "VTOYCLI" + App.Global.UpgradeOrInstall + App.Global.DriverNo + App.Global.PartitionType
            + App.Global.SecureBoot + App.Global.DiskLastSpace + App.Global.FileSystem + App.Global.LosslessInstallation;
        p.Start();
    }

    private void Update_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        //Process.Start("Ventoy_X64.exe");
        var hwnd = FindWindow("VENTOY", "114514");
        int value = SendMessage(hwnd, 0x402, (IntPtr)MakeMessageHelper.MakeWParam(0, 0x403), IntPtr.Zero).ToInt32();
        MessageDialog md = new MessageDialog(value.ToString(), "Test");
        md.ShowAsync();
        App.Global.UpgradeOrInstall = " /I";
        System.Diagnostics.Process p = new Process();
        p.StartInfo.UseShellExecute = true;
        p.StartInfo.FileName = "D:\\VentoyDebug\\Ventoy2Disk.exe";
        p.StartInfo.Arguments = "VTOYCLI" + App.Global.UpgradeOrInstall + App.Global.DriverNo + App.Global.PartitionType
            + App.Global.SecureBoot + App.Global.DiskLastSpace + App.Global.FileSystem + App.Global.LosslessInstallation;
        p.Start();
    }
}
