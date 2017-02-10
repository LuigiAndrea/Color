using static Color.ColorChange;
using static System.Console;
using System;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void WriteColor()
        {
            WriteLineWithColor(String.Empty, ConsoleColor.Red,ConsoleColor.DarkYellow);
            Assert.True(ForegroundColor == ConsoleColor.Gray);
            Assert.True(BackgroundColor == ConsoleColor.Black);
        }
    }
}
