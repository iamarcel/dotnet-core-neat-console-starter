using Microsoft.Extensions.CommandLineUtils;

namespace ConsoleStarter.Commands
{

    public class RootCommand : ICommand
    {

        public static void Configure(CommandLineApplication app, CommandLineOptions options)
        {

            app.Command("greet", c => GreetCommand.Configure(c, options));

            app.OnExecute(() =>
                {
                    options.Command = new RootCommand(app);

                    return 0;
                });

        }

        private readonly CommandLineApplication _app;

        public RootCommand(CommandLineApplication app)
        {
            _app = app;
        }

        public void Run()
        {
            _app.ShowHelp();
        }

    }

}
