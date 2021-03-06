﻿using static System.Console;
using System;

namespace Color
{
    public static class ColorChange
    {
        public static void WriteLineWithColor(string text, ConsoleColor? color = ConsoleColor.White, ConsoleColor? background = ConsoleColor.Black)
        {
            BackgroundColor = (ConsoleColor)background;
            ForegroundColor = (ConsoleColor)color;
            Write(text);
            ResetColor();
            WriteLine();
        }
        
        public static void WriteWithColor(string text, ConsoleColor? color = ConsoleColor.White, ConsoleColor? background = ConsoleColor.Black)
        {
            BackgroundColor = (ConsoleColor)background;
            ForegroundColor = (ConsoleColor)color;
            Write(text);
            ResetColor();
        }

        public static void ChangeDefaultColor(ConsoleColor foreground, ConsoleColor? background = ConsoleColor.Black)
        {
            ForegroundColor = foreground;
            BackgroundColor = (ConsoleColor)background;
        }

        public static void ResetDefaultColor()
        {
            ResetColor();
            for (int i = 0; i < BufferHeight; i++)
                Write(String.Empty);
        }

    }
}

