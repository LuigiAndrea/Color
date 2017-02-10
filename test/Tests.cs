using static Color.ColorChange;
using static System.Console;
using System;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [TheoryAttribute]
        [InlineDataAttribute("Ciao",ConsoleColor.Red)]
        public void WriteColor(String a,ConsoleColor b) 
        {
            WriteLineWithColor(a,b);
            Assert.True(ForegroundColor.ToString().Equals(ConsoleColor.Gray.ToString()));    
        }
    }
}
