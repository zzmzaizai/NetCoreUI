﻿using System.Runtime.InteropServices;

namespace NetCoreUI.Mac.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct CGPoint
    {
        public double X;
        public double Y;

        public CGPoint(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
