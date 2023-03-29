using VentoyUI.Helpers;

namespace VentoyUI;

public sealed partial class MainWindow : WindowEx
{
    public MainWindow()
    {
        InitializeComponent();

        AppWindow.SetIcon(Path.Combine(AppContext.BaseDirectory, "Assets/WindowIcon.ico"));
        Content = null;
        Title = "AppDisplayName".GetLocalized();

        ////将内容区域拓展至标题栏
        //ExtendsContentIntoTitleBar = true;
        
        ////指定拖动区域
        //SetTitleBar(AppTitleBar);
    }
}
