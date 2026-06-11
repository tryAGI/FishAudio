#nullable enable

using System.CommandLine;
using FishAudio.CLI;
using FishAudio.CLI.Commands;

var rootCommand = new RootCommand(@"CLI tool for the FishAudio SDK.");
rootCommand.Options.Add(CliOptions.ApiKey);
rootCommand.Options.Add(CliOptions.BaseUrl);
rootCommand.Options.Add(CliOptions.Json);
rootCommand.Options.Add(CliOptions.Output);
rootCommand.Options.Add(CliOptions.OutputDirectory);
rootCommand.Subcommands.Add(AuthCommand.Create());
rootCommand.Subcommands.Add(ModelApiGroupCommand.Create());
rootCommand.Subcommands.Add(OpenAPIV1ApiGroupCommand.Create());
rootCommand.Subcommands.Add(WalletApiGroupCommand.Create());

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);