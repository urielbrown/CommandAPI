using System;
using Xunit;
using CommandApi.Models;

namespace CommandApi.Tests
{
    public class CommandTests : IDisposable
    {
        Command testCommand;

        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something",
                Platform = "Some platform",
                CommandLine = "Some commandLine"
            };
        }

        public void Dispose()
        {
            testCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {            
            testCommand.HowTo = "Execute Unit Tests";

            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            testCommand.Platform = "Execute Unit Tests";

            Assert.Equal("Execute Unit Tests", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {            
            testCommand.CommandLine = "Execute Unit Tests";

            Assert.Equal("Execute Unit Tests", testCommand.CommandLine);
        }
    }
}