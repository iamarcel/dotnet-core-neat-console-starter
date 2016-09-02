using System;
using Microsoft.Extensions.CommandLineUtils;

namespace ConsoleStarter.Commands
{

    public class GreetCommand : ICommand
    {

        public static void Configure(CommandLineApplication command, CommandLineOptions options)
        {

            command.Description = "An example command from the neat .NET Core Starter";
            command.HelpOption("--help|-h|-?");

            var nameArgument = command.Argument("name",
                                   "Name I should say hello to");

            command.OnExecute(() =>
                {
                    options.Command = new GreetCommand(nameArgument.Value, options);

                    return 0;
                });

        }

        private readonly string _name;
        private readonly CommandLineOptions _options;

        public GreetCommand(string name, CommandLineOptions options)
        {
            _name = name;
            _options = options;
        }

        public void Run()
        {
            Console.WriteLine("Hello "
                + (_name != null ? _name : "World")
                + (_options.IsEnthousiastic ? "!!!" : "."));
        }

    }

}
