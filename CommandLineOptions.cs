using Microsoft.Extensions.CommandLineUtils;
using ConsoleStarter.Commands;
using ConsoleStarter.CommandConfiguration;

namespace ConsoleStarter
{

    public class CommandLineOptions
    {

        public static CommandLineOptions Parse(string[] args)
        {
            var options = new CommandLineOptions();

            var app = new CommandLineApplication
            {
                Name = "console-starter",
                FullName = ".NET Core Neat Console Starter"
            };

            app.HelpOption("-?|-h|--help");



            var enthousiasticSwitch = app.Option("-e|--enthousiastically",
                                          "Whether the app should be enthousiastic.",
                                          CommandOptionType.NoValue);



            RootCommandConfiguration.Configure(app, options);

            var result = app.Execute(args);

            if (result != 0)
            {
                return null;
            }

            options.IsEnthousiastic = enthousiasticSwitch.HasValue();

            return options;
        }

        public ICommand Command { get; set; }
        public bool IsEnthousiastic { get; set; }

    }

}
