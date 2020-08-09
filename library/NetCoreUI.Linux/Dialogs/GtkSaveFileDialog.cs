using System;
using NetCoreUI.Linux.Interop;
using NetCoreUI.Linux.Native;

namespace NetCoreUI.Linux
{
    internal class GtkSaveFileDialog : GtkFileDialog, ISaveFileDialog
    {
        public bool OverwritePrompt { get; set; }

        protected override GtkFileChooserAction Type
        {
            get { return GtkFileChooserAction.Save; }
        }

        protected override void BeforeShow(IntPtr dialog)
        {
            base.BeforeShow(dialog);
            Gtk.Dialog.SetOverwriteConfirmation(dialog, OverwritePrompt);
        }
    }
}
