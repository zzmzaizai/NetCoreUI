using System;
using NetCoreUI.Linux.Native;
using NetCoreUI.Tools;

namespace NetCoreUI.Linux
{
    internal class GtkMenu : IMenu
    {
        public readonly IntPtr Handle;

        public GtkMenu()
        {
            Handle = Gtk.Menu.Create();
        }

        public void AddItem(IMenuItem item)
        {
            if (item == null) { throw new ArgumentNullException(nameof(item)); }

            var nativeItem = NativeCast.To<GtkMenuItem>(item);
            Gtk.Menu.AddItem(Handle, nativeItem.Handle);
            Gtk.Widget.Show(nativeItem.Handle);
        }

        public void Dispose()
        {
            Gtk.Widget.Destroy(Handle);
        }
    }
}
