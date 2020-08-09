﻿using System.Windows.Forms;

namespace NetCoreUI.Win
{
    internal class WinFormsSeparatorMenuItem : WinFormsMenuItem
    {
        public override ToolStripItem Item { get; }

        public WinFormsSeparatorMenuItem()
        {
            Item = new ToolStripSeparator();
        }
    }
}
