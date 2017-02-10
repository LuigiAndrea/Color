using System;
using static Color.ColorChange;

namespace ColorApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteLineWithColor("Ciao", ConsoleColor.Red);
            WriteWithColor("Luigi", ConsoleColor.Yellow);
        }
    }
}
