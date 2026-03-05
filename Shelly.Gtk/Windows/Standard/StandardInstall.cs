using Gtk;

namespace Shelly.Gtk.Windows.Standard;

public class StandardInstall : IShellyWindow
{
    public Widget CreateWindow()
    {
        var builder = Builder.NewFromFile("UiFiles/Package/PackageWindow.ui");
        return (Overlay)builder.GetObject("PackageWindow")!;
    }
}