﻿using System;

namespace NetCoreUI.Tools
{
    internal static class ColorTools
    {
        public static void ParseHex(string color, out byte r, out byte g, out byte b)
        {
            color = color?.TrimStart('#');
            if (string.IsNullOrWhiteSpace(color) || color.Length != 6)
            {
                color = "FFFFFF";
            }

            r = Convert.ToByte(color.Substring(0, 2), 16);
            g = Convert.ToByte(color.Substring(2, 2), 16);
            b = Convert.ToByte(color.Substring(4, 2), 16);
        }

        public static string ToHex(byte r, byte g, byte b)
        {
            return $"#{r.ToString("X2")}{g.ToString("X2")}{b.ToString("X2")}";
        }
    }
}
