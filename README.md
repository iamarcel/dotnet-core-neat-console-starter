# .NET Core Neat Console Starter

This is a starting point for creating neatly structured .NET Core console apps
in C#, using the `Microsoft.Extensions.CommandLineUtils` package to parse the
commands.

I created this working as a student with [4DVision][1], who create custom
software for complex processes of companies and organizations.


## Adding a command
`GreetCommand` is an example of a command, see `Commands/GreetCommand.cs`.

1. Create a new class for your command, eg. `Commands.ListCommand`
2. Register the command in the `RootCommand` like this:

```cs
app.Command("list", c => ListCommand.Configure(c, options));
```

3. Profit!


## Adding a global option
`IsEnthousiastic` is an example of a global option.

1. Add the property to `CommandLineOptions`
2. Add a call to `app.Option` or `app.Argument` in `CommandLineOptions.Parse`
   and store the result
3. Store the property in `options` at the bottom of `CommandLineOptions.Parse`


## Learn more

- Article: [Creating Neat .NET Core Console Apps][2]
- Article: [Structuring Neat .NET Core Console Apps Neatly][3]

[1]: http://www.4dvision.be
[2]: https://gist.github.com/iamarcel/8047384bfbe9941e52817cf14a79dc34
[3]: https://gist.github.com/iamarcel/9bdc3f40d95c13f80d259b7eb2bbcabb
