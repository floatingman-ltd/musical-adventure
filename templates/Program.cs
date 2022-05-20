using System;
using Xunit;
using FluentAssertions;
using System.IO;

namespace AsConsole;

// needs to be a public class
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
        var sw = new StringWriter();
        Console.SetOut(sw);

        Program.Main(Array.Empty<string>());
        // not for console writeline - it needs the '\n'
        sw.ToString().Should().Be("Hello World!\n");

    }

#endif

}

