using System;
using Microsoft.Extensions.CommandLineUtils;

namespace ConsoleStarter.Commands
{

    public class GreetCommand : ICommand
    {

        private readonly string _name;
        private readonly CommandLineOptions _options;

        public GreetCommand(string name, CommandLineOptions options)
        {
            _name = name;
            _options = options;
        }

        public int Run()
        {
            Console.WriteLine("Hello "
                + (_name != null ? _name : "World")
                + (_options.IsEnthousiastic ? "!!!" : "."));

            return 0;
        }

    }

}
