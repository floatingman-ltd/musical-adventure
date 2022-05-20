using System;
using Xunit;
using FluentAssertions;
using System.IO;

namespace AsConsole;

// needs to be a public class for the embedded tests to be detected
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }

#if DEBUG

    [Fact]
    public void HelloWorldTest()
    {
        // capture the console output
        var console = Console.Out;
        var sw = new StringWriter();
        Console.SetOut(sw);

        Program.Main(Array.Empty<string>());
        sw.ToString().Should().Be($"Hello World!{Environment.NewLine}");

        // reset the console
        Console.SetOut(console);
    }

#endif
}
