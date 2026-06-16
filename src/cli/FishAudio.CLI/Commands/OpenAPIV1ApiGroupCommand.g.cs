#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static class OpenAPIV1ApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"open-api-v1", @"OpenAPI v1 endpoint commands.");
                         command.Subcommands.Add(OpenAPIV1CreateAsrCommandApiCommand.Create());
                         command.Subcommands.Add(OpenAPIV1CreateTtsCommandApiCommand.Create());
                         command.Subcommands.Add(OpenAPIV1CreateTtsStreamWithTimestampCommandApiCommand.Create());
                         command.Subcommands.Add(OpenAPIV1CreateVoiceDesignCommandApiCommand.Create());
        return command;
    }
}