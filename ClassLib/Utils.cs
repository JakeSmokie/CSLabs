﻿using System;

namespace CSLabs
{
    public delegate bool BoolAction();

    public static class Utils
    {

        public static void CleanPreviousLine(int offset)
        {
            Console.CursorTop -= 1;
            Console.MoveBufferArea(offset, Console.CursorTop, Console.BufferWidth - offset, 1, Console.BufferWidth, Console.CursorTop, ' ', Console.ForegroundColor, Console.BackgroundColor);
            Console.CursorLeft = offset;
        }
    }
}
