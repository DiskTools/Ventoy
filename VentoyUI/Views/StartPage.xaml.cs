using System.Diagnostics;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using VentoyUI.Helpers;
using VentoyUI.ViewModels;

namespace VentoyUI.Views;

public sealed partial class StartPage : Page
{
    public static class Global
    {
        public static int DiskLastSpace_Num = 0;
    }
    private void DiskLastSpace_Num_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
    {
        // Only get results when it was a user typing, 
        // otherwise assume the value got filled in by TextMemberPath 
        // or the handler for SuggestionChosen.
        if (DiskLastSpace.IsOn == true)
        {
            if (DiskLastSpace_Unit.SelectedIndex.ToString() == "0")
            {
                if (DiskLastSpace_Num.Text != "")
                    Global.DiskLastSpace_Num = Convert.ToInt32(DiskLastSpace_Num.Text) * 1024;
                else
                    Global.DiskLastSpace_Num = 0;
            }
            else if (DiskLastSpace_Unit.SelectedIndex.ToString() == "1")
            {
                if (DiskLastSpace_Num.Text != "")
                    Global.DiskLastSpace_Num = Convert.ToInt32(DiskLastSpace_Num.Text);
                else
                    Global.DiskLastSpace_Num = 0;
            }
            else if (DiskLastSpace_Unit.SelectedIndex.ToString() == "2")
            {
                if (DiskLastSpace_Num.Text != "")
                    Global.DiskLastSpace_Num = Convert.ToInt32(DiskLastSpace_Num.Text) / 1024;
                else
                    Global.DiskLastSpace_Num = 0;
            }
            App.Global.DiskLastSpace = " /R:" + Global.DiskLastSpace_Num.ToString();
        }
    }
    
    public class ItemHeader
    {

    }
    public StartViewModel ViewModel
    {
        get;
    }

    public StartPage()
    {
        ViewModel = App.GetService<StartViewModel>();
        InitializeComponent();
    }
    private void TargetBootDevice_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (TargetBootDevice.SelectedIndex.ToString() == "0")
        {
            App.Global.DriverNo = " /Drive:C:";
        }
        else if (TargetBootDevice.SelectedIndex.ToString() == "1")
        {
            App.Global.DriverNo = " /Drive:D:";
        }
        else if (TargetBootDevice.SelectedIndex.ToString() == "2")
        {
            App.Global.DriverNo = " /Drive:E:";
        }
        else if (TargetBootDevice.SelectedIndex.ToString() == "3")
        {
            App.Global.DriverNo = " /Drive:F:";
        }
    }
        private void SecureBoot_Toggled(object sender, RoutedEventArgs e)
    {
        ToggleSwitch toggleSwitch = sender as ToggleSwitch;
        if (toggleSwitch != null)
        {
            if (toggleSwitch.IsOn == true)
            {
                App.Global.SecureBoot = "";
            }
            else
            {
                App.Global.DiskLastSpace = " /NOSB";
            }
        }
    }
    private void DiskLastSpace_Unit_SelectionChanged(object sender, RoutedEventArgs e)
    {
        ComboBox ComboBox = sender as ComboBox;
        if (DiskLastSpace.IsOn == true)
        {
            if (DiskLastSpace_Unit.SelectedIndex.ToString() == "0")
            {
                if (DiskLastSpace_Num.Text != "")
                    Global.DiskLastSpace_Num = Convert.ToInt32(DiskLastSpace_Num.Text) * 1024;
                else
                    Global.DiskLastSpace_Num = 0;
            }
            else if (DiskLastSpace_Unit.SelectedIndex.ToString() == "1")
            {
                if (DiskLastSpace_Num.Text != "")
                    Global.DiskLastSpace_Num = Convert.ToInt32(DiskLastSpace_Num.Text);
                else
                    Global.DiskLastSpace_Num = 0;
            }
            else if(DiskLastSpace_Unit.SelectedIndex.ToString() == "2")
            {
                if (DiskLastSpace_Num.Text != "")
                    Global.DiskLastSpace_Num = Convert.ToInt32(DiskLastSpace_Num.Text) / 1024;
                else
                    Global.DiskLastSpace_Num = 0;
            }
            App.Global.DiskLastSpace = " /R:" + Global.DiskLastSpace_Num.ToString();
        }
    }
    private void PartitionType_SelectionChanged(object sender, RoutedEventArgs e)
    {
        ComboBox ComboBox = sender as ComboBox;
        if (ComboBox != null)
        {
            if (PartitionType.SelectedIndex.ToString() == "0")
            App.Global.PartitionType = " /" + "MBR";
            else if(PartitionType.SelectedIndex.ToString() == "1")
                App.Global.PartitionType = " /" + "GPT";
        }
    }
    private void FileSystem_SelectionChanged(object sender, RoutedEventArgs e)
    {
        RadioButtons ComboBox = sender as RadioButtons;
        if (ComboBox != null)
        {
            if (BackgroundRadioButtons.SelectedIndex.ToString() == "0")
                App.Global.FileSystem = " /" + "EXFAT";
            else if (BackgroundRadioButtons.SelectedIndex.ToString() == "1")
                App.Global.FileSystem = " /" + "NTFS";
            else if (BackgroundRadioButtons.SelectedIndex.ToString() == "2")
                App.Global.FileSystem = " /" + "FAT32";
            else if (BackgroundRadioButtons.SelectedIndex.ToString() == "3")
                App.Global.FileSystem = " /" + "UDF";
        }
    }

    private void DiskLastSpace_Toggled(object sender, RoutedEventArgs e)
    {
        ToggleSwitch toggleSwitch = sender as ToggleSwitch;
        if (toggleSwitch != null)
        {
            if (toggleSwitch.IsOn == true)
            {
                if (DiskLastSpace_Unit.SelectedIndex.ToString() == "0")
                {
                    if (DiskLastSpace_Num.Text != "")
                        Global.DiskLastSpace_Num = Convert.ToInt32(DiskLastSpace_Num.Text) * 1024;
                    else
                        Global.DiskLastSpace_Num = 0;
                }
                else if (DiskLastSpace_Unit.SelectedIndex.ToString() == "1")
                {
                    if (DiskLastSpace_Num.Text != "")
                        Global.DiskLastSpace_Num = Convert.ToInt32(DiskLastSpace_Num.Text);
                    else
                        Global.DiskLastSpace_Num = 0;
                }
                else if (DiskLastSpace_Unit.SelectedIndex.ToString() == "2")
                {
                    if (DiskLastSpace_Num.Text != "")
                        Global.DiskLastSpace_Num = Convert.ToInt32(DiskLastSpace_Num.Text) / 1024;
                    else
                        Global.DiskLastSpace_Num = 0;
                }
                App.Global.DiskLastSpace = " /R:" + Global.DiskLastSpace_Num.ToString();
            }
            else
            {
                App.Global.DiskLastSpace = "";
            }
        }
    }

    private void LosslessInstallation_Toggled(object sender, RoutedEventArgs e)
    {
        ToggleSwitch toggleSwitch = sender as ToggleSwitch;
        if (toggleSwitch != null)
        {
            if (toggleSwitch.IsOn == true)
            {
                App.Global.LosslessInstallation = " /NonDest";
            }
            else
            {
                App.Global.LosslessInstallation = "";
            }
        }
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        t114.Header = VentoyCoreLibHelper.Test();
    }
}


