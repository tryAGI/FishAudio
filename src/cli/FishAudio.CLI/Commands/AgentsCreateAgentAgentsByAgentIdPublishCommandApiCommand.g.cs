#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentsCreateAgentAgentsByAgentIdPublishCommandApiCommand
{
    private static Argument<string> AgentId { get; } = new(
        name: @"agent-id")
    {
        Description = @"",
    };

    private static Option<string?> VersionTitle { get; } = new(
        name: @"--version-title")
    {
        Description = @"Optional label shown in the version history.",
    };

    private static Option<string?> VersionDescription { get; } = new(
        name: @"--version-description")
    {
        Description = @"Optional longer note for audit and rollback context.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.CreateAgentAgentsPublishResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.CreateAgentAgentsPublishResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-agent-agents-by-agent-id-publish", @"Publish Agent
Freeze the current draft into an immutable version (version_number
auto-increments) and make it the live configuration for new sessions. If
the draft already matches the live version, return that version unchanged.
The body is optional; the title and description label a newly created
version for audit and rollback.");
                        command.Arguments.Add(AgentId);
                        command.Options.Add(VersionTitle);
                        command.Options.Add(VersionDescription);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.CreateAgentAgentsPublishRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var agentId = parseResult.GetRequiredValue(AgentId);
                        var versionTitle = CliRuntime.WasSpecified(parseResult, VersionTitle) ? parseResult.GetValue(VersionTitle) : (__requestBase is { } __VersionTitleBaseValue ? __VersionTitleBaseValue.VersionTitle : default);
                        var versionDescription = CliRuntime.WasSpecified(parseResult, VersionDescription) ? parseResult.GetValue(VersionDescription) : (__requestBase is { } __VersionDescriptionBaseValue ? __VersionDescriptionBaseValue.VersionDescription : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Agents.CreateAgentAgentsByAgentIdPublishAsync(
                                    agentId: agentId,
                                    versionTitle: versionTitle,
                                    versionDescription: versionDescription,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::FishAudio.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}