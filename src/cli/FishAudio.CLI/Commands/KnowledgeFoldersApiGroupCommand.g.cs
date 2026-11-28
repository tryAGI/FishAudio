#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class KnowledgeFoldersApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"knowledge-folders", @"Knowledge Folders endpoint commands.");
                         command.Subcommands.Add(KnowledgeFoldersCreateAgentKnowledgeFoldersCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeFoldersDeleteAgentKnowledgeFoldersByFolderIdCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeFoldersEditAgentKnowledgeFoldersByFolderIdCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeFoldersGetAgentKnowledgeFoldersCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}