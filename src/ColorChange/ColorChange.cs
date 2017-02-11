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

        public static void ChangeDefaultColor(ConsoleColor foreground, ConsoleColor? background = ConsoleColor.Black)
        {
            ForegroundColor = foreground;
            BackgroundColor = (ConsoleColor)background;
            ColorStatus.ColorForeground = foreground;
            ColorStatus.ColorBackground = (ConsoleColor)background;
        }

        public static void ResetDefaultColor()
        {
            Console.ResetColor();
            for (int i = 0; i < Console.BufferHeight; i++) Console.Write(String.Empty);
        }

        public static class ColorStatus
        {
            public static ConsoleColor ColorForeground ;
            public static ConsoleColor ColorBackground;
        }
    }


}
