#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentSessionsCreateAgentSessionsCommandApiCommand
{
    private static Option<string?> Origin { get; } = new(
        name: @"--origin")
    {
        Description = @"",
    };

    private static Option<string> AgentId { get; } = new(
        name: @"--agent-id")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.AgentSessionCreatePayloadLanguage2?> Language { get; } = new(
        name: @"--language")
    {
        Description = @"",
    };

    private static Option<string?> Timezone { get; } = new(
        name: @"--timezone")
    {
        Description = @"",
    };

    private static Option<string?> ClientTimezone { get; } = new(
        name: @"--client-timezone")
    {
        Description = @"",
    };

    private static Option<bool?> WorldContext { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--world-context",
        description: @"");

    private static Option<global::FishAudio.AgentSessionOverridesPayload?> Overrides { get; } = new(
        name: @"--overrides")
    {
        Description = @"",
    };

    private static Option<object?> DynamicVariables { get; } = new(
        name: @"--dynamic-variables")
    {
        Description = @"",
    };

    private static Option<string?> EndUserId { get; } = new(
        name: @"--end-user-id")
    {
        Description = @"",
    };

    private static Option<object?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"",
    };

    private static Option<bool?> ToolEvents { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--tool-events",
        description: @"");

    private static Option<bool?> RecordAudio { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--record-audio",
        description: @"");
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

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.CreateAgentSessionsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.CreateAgentSessionsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-agent-sessions", @"Create Agent Session
Start a conversation session with an agent and receive a join token for the
session transport (currently LiveKit WebRTC). Authenticate with an API key to
start sessions with any agent in your team; without credentials only agents
published as public are reachable, and the request `Origin` must match the
agent's allowed origins.

`language` (and `overrides.language`) accepts `en`, `ja`, `zh`, `ko`, `es`,
`fr`, `de`; anything else is 422. Omit it to use the agent's configured
behavior (including automatic language detection when enabled).");
                        command.Options.Add(Origin);
                        command.Options.Add(AgentId);
                        command.Options.Add(NameOption);
                        command.Options.Add(Language);
                        command.Options.Add(Timezone);
                        command.Options.Add(ClientTimezone);
                        command.Options.Add(WorldContext);
                        command.Options.Add(Overrides);
                        command.Options.Add(DynamicVariables);
                        command.Options.Add(EndUserId);
                        command.Options.Add(Metadata);
                        command.Options.Add(ToolEvents);
                        command.Options.Add(RecordAudio);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.AgentSessionCreatePayload>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var origin = parseResult.GetValue(Origin);
                        var agentId = parseResult.GetRequiredValue(AgentId);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var language = CliRuntime.WasSpecified(parseResult, Language) ? parseResult.GetValue(Language) : (__requestBase is { } __LanguageBaseValue ? __LanguageBaseValue.Language : default);
                        var timezone = CliRuntime.WasSpecified(parseResult, Timezone) ? parseResult.GetValue(Timezone) : (__requestBase is { } __TimezoneBaseValue ? __TimezoneBaseValue.Timezone : default);
                        var clientTimezone = CliRuntime.WasSpecified(parseResult, ClientTimezone) ? parseResult.GetValue(ClientTimezone) : (__requestBase is { } __ClientTimezoneBaseValue ? __ClientTimezoneBaseValue.ClientTimezone : default);
                        var worldContext = CliRuntime.WasSpecified(parseResult, WorldContext) ? parseResult.GetValue(WorldContext) : (__requestBase is { } __WorldContextBaseValue ? __WorldContextBaseValue.WorldContext : default);
                        var overrides = CliRuntime.WasSpecified(parseResult, Overrides) ? parseResult.GetValue(Overrides) : (__requestBase is { } __OverridesBaseValue ? __OverridesBaseValue.Overrides : default);
                        var dynamicVariables = CliRuntime.WasSpecified(parseResult, DynamicVariables) ? parseResult.GetValue(DynamicVariables) : (__requestBase is { } __DynamicVariablesBaseValue ? __DynamicVariablesBaseValue.DynamicVariables : default);
                        var endUserId = CliRuntime.WasSpecified(parseResult, EndUserId) ? parseResult.GetValue(EndUserId) : (__requestBase is { } __EndUserIdBaseValue ? __EndUserIdBaseValue.EndUserId : default);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                        var toolEvents = CliRuntime.WasSpecified(parseResult, ToolEvents) ? parseResult.GetValue(ToolEvents) : (__requestBase is { } __ToolEventsBaseValue ? __ToolEventsBaseValue.ToolEvents : default);
                        var recordAudio = CliRuntime.WasSpecified(parseResult, RecordAudio) ? parseResult.GetValue(RecordAudio) : (__requestBase is { } __RecordAudioBaseValue ? __RecordAudioBaseValue.RecordAudio : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AgentSessions.CreateAgentSessionsAsync(
                                    origin: origin,
                                    agentId: agentId,
                                    name: name,
                                    language: language,
                                    timezone: timezone,
                                    clientTimezone: clientTimezone,
                                    worldContext: worldContext,
                                    overrides: overrides,
                                    dynamicVariables: dynamicVariables,
                                    endUserId: endUserId,
                                    metadata: metadata,
                                    toolEvents: toolEvents,
                                    recordAudio: recordAudio,
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