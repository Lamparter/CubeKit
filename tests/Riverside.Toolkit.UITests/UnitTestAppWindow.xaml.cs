using System;
using System.IO;
using System.Threading.Tasks;
using WinUIEx;

namespace Riverside.Toolkit.UITests;

public sealed partial class UnitTestAppWindow : WindowEx
{
    public UnitTestAppWindow()
    {
        InitializeComponent();
        TitleBar.InitializeForWindow(this);
        Load();
    }

    public async void Load()
    {
        await Task.Delay(500);
        TitleBar.SetWindowIcon(new("ms-appx:///Assets/Rebound.ico"), Path.Combine(AppContext.BaseDirectory, "Assets", "Rebound.ico"));
        SystemBackdrop = new Microsoft.UI.Xaml.Media.MicaBackdrop() { Kind = Microsoft.UI.Composition.SystemBackdrops.MicaKind.BaseAlt };
    }
}