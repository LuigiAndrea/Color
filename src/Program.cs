using System;
using static Color.ColorChange;

namespace ColorApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteWithColor("Ciao ", ConsoleColor.Red);
            WriteLineWithColor("Luigi ", ConsoleColor.Yellow, ConsoleColor.Blue);
        }
    }
}
