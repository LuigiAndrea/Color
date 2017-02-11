using static System.Console;
using static Color.ColorChange;
using System;

namespace ColorApplication
{
    public class ColorExample
    {
        public static void Main(string[] args)
        {
            WriteWithColor("Ciao ", ConsoleColor.Red);
            WriteLineWithColor("Luigi", ConsoleColor.Yellow, ConsoleColor.Blue);
            ChangeDefaultColor(ConsoleColor.Green,ConsoleColor.DarkRed);
            WriteLine("Test");
            ResetDefaultColor();
            WriteLine("Test After Reset");
        }
    }
}
