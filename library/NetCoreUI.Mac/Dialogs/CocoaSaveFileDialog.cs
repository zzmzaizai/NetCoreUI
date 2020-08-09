using NetCoreUI.Mac.Interop;

namespace NetCoreUI.Mac
{
    internal class CocoaSaveFileDialog : CocoaFileDialog, ISaveFileDialog
    {
        public bool OverwritePrompt { get; set; }

        protected override NSDialog CreateDialog()
        {
            // TODO: can't disable overwrite prompt on macOS
            return NSDialog.CreateSavePanel();
        }
    }
}
