using System;
using System.Windows.Forms;
using NetCoreUI.Tools;

namespace NetCoreUI.Win
{
    internal class WinFormsMenu : IMenu
    {
        public readonly ContextMenuStrip Menu = new ContextMenuStrip();

        public void AddItem(IMenuItem item)
        {
            if (item == null) { throw new ArgumentNullException(nameof(item)); }

            var nativeItem = NativeCast.To<WinFormsMenuItem>(item);
            Menu.Items.Add(nativeItem.Item);
        }

        public void Dispose()
        {
            Menu.Dispose();
        }
    }
}
