using NetCoreUI.Linux.Native;

namespace NetCoreUI.Linux
{
    internal class GtkSeparatorMenuItem : GtkMenuItem
    {
        public GtkSeparatorMenuItem()
            : base(Gtk.Menu.CreateSeparatorItem())
        {
        }
    }
}
