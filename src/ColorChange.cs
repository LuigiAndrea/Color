using static System.Console;
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
            Console.ResetColor();
            WriteLine();
        }

        public static void WriteWithColor(string text, ConsoleColor? color = ConsoleColor.White, ConsoleColor? background = ConsoleColor.Black)
        {
            BackgroundColor = (ConsoleColor)background;
            ForegroundColor = (ConsoleColor)color;
            Write(text);
            Console.ResetColor();
        }
    }
}