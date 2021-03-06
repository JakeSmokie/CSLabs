﻿using System;

namespace CSLabs
{
    public static class Extensions
    {
        public static string ToWolfString(this double val) => $"{ val }{ (val - Math.Truncate(val) > 0 || val.ToString().Contains("E") ? "" : ".0") }";
    }
}
