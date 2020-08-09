using NetCoreUI.Mac.Native;

namespace NetCoreUI.Mac
{
    internal class CocoaSeparatorMenuItem : CocoaMenuItem
    {
        public CocoaSeparatorMenuItem()
            : base(AppKit.Call("NSMenuItem", "separatorItem"))
        {
        }
    }
}
