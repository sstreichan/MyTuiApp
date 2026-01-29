using Spectre.Console;
using Spectre.Console.Cli;

var app = new CommandApp();
app.Configure(config =>
{
    config.SetApplicationName("mytui");
    
    // Commands hier registrieren
});

return app.Run(args);
