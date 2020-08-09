using System;
using NetCoreUI.Mac.Native;

namespace NetCoreUI.Mac.Interop
{
    internal static class URL
    {
        public static string GetAsString(IntPtr handle)
        {
            if (handle == IntPtr.Zero) { return null; }

            return NSString.GetString(ObjC.Call(handle, "absoluteString"));
        }

        public static Uri GetAsUri(IntPtr handle)
        {
            if (handle == IntPtr.Zero) { return null; }

            return new Uri(GetAsString(handle));
        }
    }
}
