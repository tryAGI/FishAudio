#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class OpenAPIV1ApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"open-api-v1", @"OpenAPI v1 endpoint commands.");
                         command.Subcommands.Add(OpenAPIV1CreateAsrCommandApiCommand.Create());
                         command.Subcommands.Add(OpenAPIV1CreateAsrWithMessagePackCommandApiCommand.Create());
                         command.Subcommands.Add(OpenAPIV1CreateTtsCommandApiCommand.Create());
                         command.Subcommands.Add(OpenAPIV1CreateTtsStreamWithTimestampCommandApiCommand.Create());
                         command.Subcommands.Add(OpenAPIV1CreateTtsStreamWithTimestampWithMessagePackCommandApiCommand.Create());
                         command.Subcommands.Add(OpenAPIV1CreateTtsWithMessagePackCommandApiCommand.Create());
                         command.Subcommands.Add(OpenAPIV1CreateVoiceDesignCommandApiCommand.Create());
                         command.Subcommands.Add(OpenAPIV1GetTtsLiveWithTimestampCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}