#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static class KnowledgeSourcesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"knowledge-sources", @"Knowledge Sources endpoint commands.");
                         command.Subcommands.Add(KnowledgeSourcesCreateAgentKnowledgeSourcesCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeSourcesDeleteAgentKnowledgeSourcesBySourceIdCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeSourcesEditAgentKnowledgeSourcesBySourceIdCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeSourcesGetAgentKnowledgeSourcesCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeSourcesGetAgentKnowledgeSourcesBySourceIdCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeSourcesGetAgentKnowledgeSourcesBySourceIdAgentsCommandApiCommand.Create());
        return command;
    }
}