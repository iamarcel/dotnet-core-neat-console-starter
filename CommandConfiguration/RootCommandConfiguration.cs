using System;
using System.Collections.Generic;
using System.Text;
using ConsoleStarter.Commands;
using Microsoft.Extensions.CommandLineUtils;

namespace ConsoleStarter.CommandConfiguration
{
    public static class RootCommandConfiguration
    {
        public static void Configure(CommandLineApplication app, CommandLineOptions options)
        {

            app.Command("greet", c => GreetCommandConfiguration.Configure(c, options));

            app.OnExecute(() =>
            {
                options.Command = new RootCommand(app);

                return 0;
            });

        }
    }
}