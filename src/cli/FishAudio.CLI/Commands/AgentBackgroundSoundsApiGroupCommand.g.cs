#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentBackgroundSoundsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"agent-background-sounds", @"Agent Background Sounds endpoint commands.");
                         command.Subcommands.Add(AgentBackgroundSoundsCreateAgentBackgroundSoundsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentBackgroundSoundsDeleteAgentBackgroundSoundsByAssetIdCommandApiCommand.Create());
                         command.Subcommands.Add(AgentBackgroundSoundsGetAgentBackgroundSoundsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}