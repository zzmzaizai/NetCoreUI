using System.Runtime.InteropServices;

namespace NetCoreUI.Win.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct Point
    {
        public int X;
        public int Y;
    }
}
